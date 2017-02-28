﻿using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Spect.Net.Z80Tests.Mvvm.Attributes;

namespace Spect.Net.Z80Tests.Mvvm.Navigation
{
    /// <summary>
    /// This class is intended to be the base class of all navigable view model
    /// </summary>
    public abstract class NavigableViewModelBase : ViewModelBase
    {
        #region IsInDesignMode tweak

        // --- The current implementation of GalaSoft.MvvmLight has an issue with identifying
        // --- design mode, as it searches for the 3.0.0.0 versions of WPF-related assemblies
        // --- instead of 4.0.0.0.
        // --- This tweak fixes this issue by overriding the IsInDesignMode and 
        // --- IsInDesignModeStatic properties.

        private const string WPD_IDENTITY = "Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
        private const string WINDOWS_RUNTIME_IDENTITY = "Windows.ApplicationModel.DesignMode, Windows, ContentType=WindowsRuntime";

        private enum DesignerPlatformLibrary
        {
            Unknown,
            Net,
            WinRt
        }

        private static bool? s_IsInDesignMode;

        /// <summary>
        /// Gets a value indicating whether the control is in design mode
        /// (running in Blend or Visual Studio).
        /// </summary>
        public new static bool IsInDesignModeStatic
        {
            get
            {
                if (!s_IsInDesignMode.HasValue)
                    s_IsInDesignMode = IsInDesignModePortable();
                return s_IsInDesignMode.Value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the control is in design mode
        /// (running in Blend or Visual Studio).
        /// </summary>
        public new bool IsInDesignMode => IsInDesignModeStatic;

        /// <summary>
        /// Determines the current platform
        /// </summary>
        /// <returns></returns>
        private static DesignerPlatformLibrary GetCurrentPlatform()
        {
            if (Type.GetType($"System.ComponentModel.DesignerProperties, PresentationFramework, {WPD_IDENTITY}") != null)
                return DesignerPlatformLibrary.Net;
            return Type.GetType(WINDOWS_RUNTIME_IDENTITY) != null
                ? DesignerPlatformLibrary.WinRt
                : DesignerPlatformLibrary.Unknown;
        }

        /// <summary>
        /// Checks if design mode is in a portable library
        /// </summary>
        /// <returns></returns>
        private static bool IsInDesignModePortable()
        {
            switch (GetCurrentPlatform())
            {
                case DesignerPlatformLibrary.WinRt:
                    return IsInDesignModeWinRt();
                case DesignerPlatformLibrary.Net:
                    return IsInDesignModeNet();
                default:
                    return false;
            }
        }

        private static bool IsInDesignModeWinRt()
        {
            try
            {
                return (bool)Type.GetType(WINDOWS_RUNTIME_IDENTITY)
                    .GetTypeInfo()
                    .GetDeclaredProperty("DesignModeEnabled")
                    .GetValue(null, null);
            }
            catch
            {
                return false;
            }
        }

        private static bool IsInDesignModeNet()
        {
            try
            {
                var dm = Type.GetType($"System.ComponentModel.DesignerProperties, PresentationFramework, {WPD_IDENTITY}");
                if (dm == null)
                {
                    return false;
                }

                var dmp = dm.GetTypeInfo().GetDeclaredField("IsInDesignModeProperty").GetValue(null);

                var dpd = Type.GetType($"System.ComponentModel.DependencyPropertyDescriptor, WindowsBase, {WPD_IDENTITY}");
                var typeFe = Type.GetType($"System.Windows.FrameworkElement, PresentationFramework, {WPD_IDENTITY}");

                if (dpd == null || typeFe == null)
                {
                    return false;
                }

                var fromPropertys = dpd
                    .GetTypeInfo()
                    .GetDeclaredMethods("FromProperty")
                    .ToList();

                if (fromPropertys == null || fromPropertys.Count == 0)
                {
                    return false;
                }

                var fromProperty = fromPropertys
                    .FirstOrDefault(mi => mi.IsPublic && mi.IsStatic && mi.GetParameters().Length == 2);

                var descriptor = fromProperty?.Invoke(null, new[] { dmp, typeFe });
                if (descriptor == null)
                {
                    return false;
                }

                var metaProp = dpd.GetTypeInfo().GetDeclaredProperty("Metadata");

                if (metaProp == null)
                {
                    return false;
                }

                var metadata = metaProp.GetValue(descriptor, null);
                var tPropMeta = Type.GetType($"System.Windows.PropertyMetadata, WindowsBase, {WPD_IDENTITY}");

                if (metadata == null || tPropMeta == null)
                {
                    return false;
                }

                var dvProp = tPropMeta.GetTypeInfo().GetDeclaredProperty("DefaultValue");

                if (dvProp == null)
                {
                    return false;
                }

                var dv = (bool)dvProp.GetValue(metadata, null);
                return dv;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        private string _viewResource;
        private string _viewTitle;
        private string _viewDetail;
        private bool _firstLoaded;
        private InitState _initState;

        /// <summary>
        /// Indicades the initialization State for the viewmodel. (ProgressBar should be visible if Initializing)
        /// </summary>
        public InitState InitState
        {
            get { return _initState; }
            set { Set(ref _initState, value); }
        }

        /// <summary>
        /// The true value indicates that there can be only a singleton instance of this 
        /// view model in the navigation stack
        /// </summary>
        public virtual bool IsSingleton { get; }

        /// <summary>
        /// The true value indicates that this view model instance is asynchronously
        /// initialized.
        /// </summary>
        public virtual bool AsyncInit { get; }

        /// <summary>
        /// The true value indicates that this view should be omitted 
        /// from the navigation history.
        /// </summary>
        public virtual bool ExcludeFromNavigationHistory { get; }

        /// <summary>
        /// This taks allows to chacke the state of initialization task from outside
        /// </summary>
        public Task InitTask { get; private set; }

        /// <summary>
        /// Convenience accessor to the SimpleIoc container from MVVM Light
        /// </summary>
        public SimpleIoc Ioc => SimpleIoc.Default;

        /// <summary>
        /// View resource information to display
        /// </summary>
        public string ViewResource
        {
            get { return _viewResource; }
            set { Set(ref _viewResource, value); }
        }

        /// <summary>
        /// View title information to display
        /// </summary>
        public string ViewTitle
        {
            get { return _viewTitle; }
            set { Set(ref _viewTitle, value); }
        }

        /// <summary>
        /// View detail information to display
        /// </summary>
        public string ViewDetail
        {
            get { return _viewDetail; }
            set { Set(ref _viewDetail, value); }
        }

        /// <summary>
        /// Sets the specified input tag right after the view model has been
        /// instantiated
        /// </summary>
        /// <param name="inputTag">Input tag to pass to the view model</param>
        /// <remarks>
        /// Override this method in a concrete view model to support parameter
        /// passing.
        /// </remarks>
        public virtual void SetInputTag(object inputTag)
        {
        }

        /// <summary>
        /// Navigation service instance
        /// </summary>
        protected INavigationService NavigationService { get; }
        
        /// <summary>
        /// Sets up this view model instance
        /// </summary>
        protected NavigableViewModelBase()
        {
            // --- Init Title and resource
            ViewResource = GetType().GetTypeInfo().GetCustomAttribute<ViewResourceAttribute>()?.Resource;
            ViewTitle = GetType().GetTypeInfo().GetCustomAttribute<ViewTitleAttribute>()?.Title;
            IsSingleton = GetType().GetTypeInfo().GetCustomAttribute<IsSingletonAttribute>()?.Value ?? false;
            AsyncInit = GetType().GetTypeInfo().GetCustomAttribute<AsyncInitAttribute>()?.Value ?? false;
            ExcludeFromNavigationHistory = GetType().GetTypeInfo()
                .GetCustomAttribute<ExcludeFromNavigationHistoryAttribute>()?.Value ?? false;
            _firstLoaded = false;

            // --- We initialize a design time navigation service, if no service
            // --- is registered
            NavigationService = Ioc.IsRegistered<INavigationService>() 
                ? Ioc.GetInstance<INavigationService>() 
                : new DesignTimeNavigationService();

            if (IsInDesignMode)
            {
                // ReSharper disable once VirtualMemberCallInContructor
                DesignTimeInit();
                InitState = InitState.Initialized;
            }
        }

        /// <summary>
        /// Invoke this method from the constructor to trigger
        /// async initialization
        /// </summary>
        public void StartAsyncInit()
        {
            if (InitState == InitState.Initialized) return;
            InitState = InitState.Initializing;
            InitTask = StartInitializationTask();
        }

        private Task StartInitializationTask()
        {
            var completionSource = new TaskCompletionSource<int>();
            var initTask = InitViewModel();
            initTask.GetAwaiter().OnCompleted(() =>
            {
                if (initTask.IsFaulted || initTask.IsCanceled)
                {
                    InitState = InitState.InitFailed;
                    OnInitViewModelFailed(initTask.Exception);
                    // ReSharper disable once AssignNullToNotNullAttribute
                    completionSource.SetException(initTask.Exception);
                }
                else
                {
                    InitState = InitState.Initialized;
                    OnInitViewModelCompleted();
                    completionSource.SetResult(0);
                }
            });
            return completionSource.Task;
        }

        /// <summary>
        /// Initializes the view model in design time
        /// </summary>
        protected virtual void DesignTimeInit()
        {
        }

        /// <summary>
        /// Asynchronously initializes this view model instance
        /// </summary>
        protected virtual Task InitViewModel()
        {
            return Task.FromResult(0);
        }

        /// <summary>
        /// Override this method to handle when initialization is completed
        /// successfully
        /// </summary>
        public virtual void OnInitViewModelCompleted()
        {
        }


        /// <summary>
        /// Overrid this method to handle when initialization failed
        /// </summary>
        /// <param name="ex">Initialization exception</param>
        protected virtual void OnInitViewModelFailed(Exception ex)
        {
        }

        /// <summary>
        /// This method is called when the view model is navigate to
        /// </summary>
        public virtual void OnViewModelNavigatedTo() { }

        /// <summary>
        /// This method is called after the view model has been navigated away.
        /// </summary>
        /// <remarks>
        /// There's no way to prevent navigation away from the view model
        /// </remarks>
        public virtual void OnViewModelLeft() { }

        /// <summary>
        /// This method is called after the view model has been removed from the navigation
        /// stack.
        /// </summary>
        /// <remarks>
        /// There's no way a view model can prevent closing it. Nonetheless, the view model
        /// initiates closing itself.
        /// </remarks>
        public virtual void OnViewModelClosed() { }

        /// <summary>
        /// This method is invoked when the view related to the view model is loaded.
        /// </summary>
        public virtual void OnViewLoaded()
        {
            if (!_firstLoaded)
            {
                _firstLoaded = true;
                OnViewInitiallyLoaded();
            }
            else
            {
                OnViewActivated();
            }
        }

        /// <summary>
        /// Override this method to handle the event when the view of the
        /// view model is first time loaded.
        /// </summary>
        protected virtual void OnViewInitiallyLoaded() { }

        /// <summary>
        /// Override this method to handle the event when the view of the
        /// view model is activated after it has been initially loaded.
        /// </summary>
        protected virtual void OnViewActivated() { }
    }
}
﻿using System;
using System.Collections.Generic;
using Spect.Net.Assembler.SyntaxTree.Expressions;

namespace Spect.Net.Assembler.Assembler
{
    /// <summary>
    /// This class represents the output of the compiler
    /// </summary>
    public class AssemblerOutput
    {
        /// <summary>
        /// The segments of the compilation output
        /// </summary>
        public List<BinarySegment> Segments { get; } = new List<BinarySegment>();

        /// <summary>
        /// The symbol table with properly defined symbols
        /// </summary>
        public Dictionary<string, ExpressionValue> Symbols { get; } =
            new Dictionary<string, ExpressionValue>(StringComparer.InvariantCultureIgnoreCase);

        /// <summary>
        /// The variable table
        /// </summary>
        public Dictionary<string, ExpressionValue> Vars { get; } =
            new Dictionary<string, ExpressionValue>(StringComparer.InvariantCultureIgnoreCase);

        /// <summary>
        /// The list of fixups to carry out as the last phase of the compilation
        /// </summary>
        public List<FixupEntry> Fixups { get; } = new List<FixupEntry>();

        /// <summary>
        /// Local symbol scopes
        /// </summary>
        public Stack<SymbolScope> LocalScopes = new Stack<SymbolScope>();

        /// <summary>
        /// The macro table
        /// </summary>
        public Dictionary<string, MacroDefinition> Macros { get; } =
            new Dictionary<string, MacroDefinition>(StringComparer.InvariantCultureIgnoreCase);

        /// <summary>
        /// The errors found during the compilation
        /// </summary>
        public List<AssemblerErrorInfo> Errors { get; } = new List<AssemblerErrorInfo>();

        /// <summary>
        /// Number of compilation errors
        /// </summary>
        public int ErrorCount => Errors.Count;

        /// <summary>
        /// Gets the tasks that were extracted from the source during the parse phase.
        /// </summary>
        public List<AssemblerTaskInfo> Tasks { get; } = new List<AssemblerTaskInfo>();

        /// <summary>
        /// The type of the Spectrum model to be used
        /// </summary>
        public SpectrumModelType? ModelType { get; set; }

        /// <summary>
        /// Entry address of the code
        /// </summary>
        public ushort? EntryAddress { get; set; }

        /// <summary>
        /// Entry address of the code
        /// </summary>
        public ushort? ExportEntryAddress { get; set; }

        /// <summary>
        /// The root source file item of the compilation
        /// </summary>
        public SourceFileItem SourceItem { get; }

        /// <summary>
        /// The source files involved in this compilation, in theor file index order
        /// </summary>
        public List<SourceFileItem> SourceFileList { get; }

        /// <summary>
        /// Source map information that assigns an address with the related source file info
        /// </summary>
        public Dictionary<ushort, (int FileIndex, int Line)> SourceMap { get; }

        /// <summary>
        /// Source map information that assigns source file info with the address
        /// </summary>
        public Dictionary<(int FileIndex, int Line), List<ushort>> AddressMap { get; }


        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public AssemblerOutput(SourceFileItem sourceItem)
        {
            SourceItem = sourceItem
                ?? throw new ArgumentNullException(nameof(sourceItem));
            SourceFileList = new List<SourceFileItem> { sourceItem };
            SourceMap = new Dictionary<ushort, (int FileIndex, int Line)>();
            AddressMap = new Dictionary<(int FileIndex, int Line), List<ushort>>();
        }

        /// <summary>
        /// Adds the specified information to the address map
        /// </summary>
        /// <param name="fileIndex">File index</param>
        /// <param name="sourceLine">Source line index</param>
        /// <param name="address">Code address</param>
        public void AddToAddressMap(int fileIndex, int sourceLine, ushort address)
        {
            var sourceInfo = (fileIndex, sourceLine);
            if (AddressMap.TryGetValue(sourceInfo, out var addressList))
            {
                addressList.Add(address);
            }
            else
            {
                AddressMap[sourceInfo] = new List<ushort> {address};
            }
        }
    }
}
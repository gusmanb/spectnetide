﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\Assembler\AntlrCommandParserGenerator\AntlrCommandParserGenerator\CommandTool.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.CommandParser.Generated {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICommandToolListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CommandToolBaseListener : ICommandToolListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompileUnit([NotNull] CommandToolParser.CompileUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompileUnit([NotNull] CommandToolParser.CompileUnitContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.toolCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterToolCommand([NotNull] CommandToolParser.ToolCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.toolCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitToolCommand([NotNull] CommandToolParser.ToolCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.gotoCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGotoCommand([NotNull] CommandToolParser.GotoCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.gotoCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGotoCommand([NotNull] CommandToolParser.GotoCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.gotoSymbolCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGotoSymbolCommand([NotNull] CommandToolParser.GotoSymbolCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.gotoSymbolCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGotoSymbolCommand([NotNull] CommandToolParser.GotoSymbolCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.romPageCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRomPageCommand([NotNull] CommandToolParser.RomPageCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.romPageCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRomPageCommand([NotNull] CommandToolParser.RomPageCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.bankPageCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBankPageCommand([NotNull] CommandToolParser.BankPageCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.bankPageCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBankPageCommand([NotNull] CommandToolParser.BankPageCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.memModeCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemModeCommand([NotNull] CommandToolParser.MemModeCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.memModeCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemModeCommand([NotNull] CommandToolParser.MemModeCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.labelCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabelCommand([NotNull] CommandToolParser.LabelCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.labelCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabelCommand([NotNull] CommandToolParser.LabelCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.commentCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommentCommand([NotNull] CommandToolParser.CommentCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.commentCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommentCommand([NotNull] CommandToolParser.CommentCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.prefixCommentCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrefixCommentCommand([NotNull] CommandToolParser.PrefixCommentCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.prefixCommentCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrefixCommentCommand([NotNull] CommandToolParser.PrefixCommentCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.setBreakpointCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetBreakpointCommand([NotNull] CommandToolParser.SetBreakpointCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.setBreakpointCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetBreakpointCommand([NotNull] CommandToolParser.SetBreakpointCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.toggleBreakpointCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterToggleBreakpointCommand([NotNull] CommandToolParser.ToggleBreakpointCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.toggleBreakpointCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitToggleBreakpointCommand([NotNull] CommandToolParser.ToggleBreakpointCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.removeBreakpointCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRemoveBreakpointCommand([NotNull] CommandToolParser.RemoveBreakpointCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.removeBreakpointCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRemoveBreakpointCommand([NotNull] CommandToolParser.RemoveBreakpointCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.updateBreakpointCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdateBreakpointCommand([NotNull] CommandToolParser.UpdateBreakpointCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.updateBreakpointCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdateBreakpointCommand([NotNull] CommandToolParser.UpdateBreakpointCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.eraseAllBreakpointsCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEraseAllBreakpointsCommand([NotNull] CommandToolParser.EraseAllBreakpointsCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.eraseAllBreakpointsCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEraseAllBreakpointsCommand([NotNull] CommandToolParser.EraseAllBreakpointsCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.retrieveCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRetrieveCommand([NotNull] CommandToolParser.RetrieveCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.retrieveCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRetrieveCommand([NotNull] CommandToolParser.RetrieveCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.literalCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralCommand([NotNull] CommandToolParser.LiteralCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.literalCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralCommand([NotNull] CommandToolParser.LiteralCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.disassemblyTypeCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDisassemblyTypeCommand([NotNull] CommandToolParser.DisassemblyTypeCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.disassemblyTypeCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDisassemblyTypeCommand([NotNull] CommandToolParser.DisassemblyTypeCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.reDisassemblyCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReDisassemblyCommand([NotNull] CommandToolParser.ReDisassemblyCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.reDisassemblyCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReDisassemblyCommand([NotNull] CommandToolParser.ReDisassemblyCommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CommandToolParser.jumpCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJumpCommand([NotNull] CommandToolParser.JumpCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommandToolParser.jumpCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJumpCommand([NotNull] CommandToolParser.JumpCommandContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Spect.Net.CommandParser.Generated
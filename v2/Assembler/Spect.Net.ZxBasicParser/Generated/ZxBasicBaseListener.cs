//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\v2\Assembler\AntlrZxBasicParserGenerator\AntlrZxBasicParserGenerator\ZxBasic.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.ZxBasicParser.Generated {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IZxBasicListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public partial class ZxBasicBaseListener : IZxBasicListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompileUnit([NotNull] ZxBasicParser.CompileUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompileUnit([NotNull] ZxBasicParser.CompileUnitContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] ZxBasicParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] ZxBasicParser.KeywordContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction([NotNull] ZxBasicParser.FunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction([NotNull] ZxBasicParser.FunctionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator([NotNull] ZxBasicParser.OperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator([NotNull] ZxBasicParser.OperatorContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.special"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecial([NotNull] ZxBasicParser.SpecialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.special"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecial([NotNull] ZxBasicParser.SpecialContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumber([NotNull] ZxBasicParser.NumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumber([NotNull] ZxBasicParser.NumberContext context) { }

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
} // namespace Spect.Net.ZxBasicParser.Generated
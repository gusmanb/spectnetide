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

namespace Spect.Net.BasicParser.Generated {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ZxBasicParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public interface IZxBasicVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] ZxBasicParser.CompileUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] ZxBasicParser.LabelContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] ZxBasicParser.LineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.line_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine_item([NotNull] ZxBasicParser.Line_itemContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.asm_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsm_section([NotNull] ZxBasicParser.Asm_sectionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.console"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConsole([NotNull] ZxBasicParser.ConsoleContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyword([NotNull] ZxBasicParser.KeywordContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] ZxBasicParser.FunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperator([NotNull] ZxBasicParser.OperatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.special"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpecial([NotNull] ZxBasicParser.SpecialContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] ZxBasicParser.NumberContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] ZxBasicParser.IdentifierContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] ZxBasicParser.StringContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] ZxBasicParser.TypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] ZxBasicParser.CommentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.block_comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock_comment([NotNull] ZxBasicParser.Block_commentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ZxBasicParser.line_comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine_comment([NotNull] ZxBasicParser.Line_commentContext context);
}
} // namespace Spect.Net.BasicParser.Generated

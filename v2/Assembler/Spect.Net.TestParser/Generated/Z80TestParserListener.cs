﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\v2\Assembler\AntlrZ80TestParserGenerator\AntlrZ80TestParserGenerator\Z80TestParser.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.TestParser.Generated {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="Z80TestParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IZ80TestParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] Z80TestParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] Z80TestParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.testSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTestSet([NotNull] Z80TestParser.TestSetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.testSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTestSet([NotNull] Z80TestParser.TestSetContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.sp48Mode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSp48Mode([NotNull] Z80TestParser.Sp48ModeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.sp48Mode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSp48Mode([NotNull] Z80TestParser.Sp48ModeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.sourceContext"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSourceContext([NotNull] Z80TestParser.SourceContextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.sourceContext"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSourceContext([NotNull] Z80TestParser.SourceContextContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.callstub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallstub([NotNull] Z80TestParser.CallstubContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.callstub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallstub([NotNull] Z80TestParser.CallstubContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.testOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTestOptions([NotNull] Z80TestParser.TestOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.testOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTestOptions([NotNull] Z80TestParser.TestOptionsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.testOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTestOption([NotNull] Z80TestParser.TestOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.testOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTestOption([NotNull] Z80TestParser.TestOptionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.dataBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataBlock([NotNull] Z80TestParser.DataBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.dataBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataBlock([NotNull] Z80TestParser.DataBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.dataBlockBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataBlockBody([NotNull] Z80TestParser.DataBlockBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.dataBlockBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataBlockBody([NotNull] Z80TestParser.DataBlockBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.valueDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValueDef([NotNull] Z80TestParser.ValueDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.valueDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValueDef([NotNull] Z80TestParser.ValueDefContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.memPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemPattern([NotNull] Z80TestParser.MemPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.memPattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemPattern([NotNull] Z80TestParser.MemPatternContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.memPatternBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemPatternBody([NotNull] Z80TestParser.MemPatternBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.memPatternBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemPatternBody([NotNull] Z80TestParser.MemPatternBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.byteSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterByteSet([NotNull] Z80TestParser.ByteSetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.byteSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitByteSet([NotNull] Z80TestParser.ByteSetContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.wordSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWordSet([NotNull] Z80TestParser.WordSetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.wordSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWordSet([NotNull] Z80TestParser.WordSetContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterText([NotNull] Z80TestParser.TextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitText([NotNull] Z80TestParser.TextContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.portMock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPortMock([NotNull] Z80TestParser.PortMockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.portMock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPortMock([NotNull] Z80TestParser.PortMockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.portPulse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPortPulse([NotNull] Z80TestParser.PortPulseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.portPulse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPortPulse([NotNull] Z80TestParser.PortPulseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.initSettings"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitSettings([NotNull] Z80TestParser.InitSettingsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.initSettings"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitSettings([NotNull] Z80TestParser.InitSettingsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.setupCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetupCode([NotNull] Z80TestParser.SetupCodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.setupCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetupCode([NotNull] Z80TestParser.SetupCodeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.cleanupCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCleanupCode([NotNull] Z80TestParser.CleanupCodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.cleanupCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCleanupCode([NotNull] Z80TestParser.CleanupCodeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.invokeCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvokeCode([NotNull] Z80TestParser.InvokeCodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.invokeCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvokeCode([NotNull] Z80TestParser.InvokeCodeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.testBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTestBlock([NotNull] Z80TestParser.TestBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.testBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTestBlock([NotNull] Z80TestParser.TestBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.testParams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTestParams([NotNull] Z80TestParser.TestParamsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.testParams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTestParams([NotNull] Z80TestParser.TestParamsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.testCase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTestCase([NotNull] Z80TestParser.TestCaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.testCase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTestCase([NotNull] Z80TestParser.TestCaseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.arrange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrange([NotNull] Z80TestParser.ArrangeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.arrange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrange([NotNull] Z80TestParser.ArrangeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] Z80TestParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] Z80TestParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.regAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRegAssignment([NotNull] Z80TestParser.RegAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.regAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRegAssignment([NotNull] Z80TestParser.RegAssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.flagStatus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlagStatus([NotNull] Z80TestParser.FlagStatusContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.flagStatus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlagStatus([NotNull] Z80TestParser.FlagStatusContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.memAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemAssignment([NotNull] Z80TestParser.MemAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.memAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemAssignment([NotNull] Z80TestParser.MemAssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.act"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAct([NotNull] Z80TestParser.ActContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.act"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAct([NotNull] Z80TestParser.ActContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.breakpoint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreakpoint([NotNull] Z80TestParser.BreakpointContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.breakpoint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreakpoint([NotNull] Z80TestParser.BreakpointContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.assert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssert([NotNull] Z80TestParser.AssertContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.assert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssert([NotNull] Z80TestParser.AssertContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.reg8"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg8([NotNull] Z80TestParser.Reg8Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.reg8"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg8([NotNull] Z80TestParser.Reg8Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.reg8Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg8Idx([NotNull] Z80TestParser.Reg8IdxContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.reg8Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg8Idx([NotNull] Z80TestParser.Reg8IdxContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.reg8Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg8Spec([NotNull] Z80TestParser.Reg8SpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.reg8Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg8Spec([NotNull] Z80TestParser.Reg8SpecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.reg16"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg16([NotNull] Z80TestParser.Reg16Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.reg16"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg16([NotNull] Z80TestParser.Reg16Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.reg16Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg16Idx([NotNull] Z80TestParser.Reg16IdxContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.reg16Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg16Idx([NotNull] Z80TestParser.Reg16IdxContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.reg16Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReg16Spec([NotNull] Z80TestParser.Reg16SpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.reg16Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReg16Spec([NotNull] Z80TestParser.Reg16SpecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.flag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlag([NotNull] Z80TestParser.FlagContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.flag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlag([NotNull] Z80TestParser.FlagContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] Z80TestParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] Z80TestParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.orExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrExpr([NotNull] Z80TestParser.OrExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.orExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrExpr([NotNull] Z80TestParser.OrExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.xorExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXorExpr([NotNull] Z80TestParser.XorExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.xorExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXorExpr([NotNull] Z80TestParser.XorExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.andExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpr([NotNull] Z80TestParser.AndExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.andExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpr([NotNull] Z80TestParser.AndExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.equExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquExpr([NotNull] Z80TestParser.EquExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.equExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquExpr([NotNull] Z80TestParser.EquExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.relExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelExpr([NotNull] Z80TestParser.RelExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.relExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelExpr([NotNull] Z80TestParser.RelExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.shiftExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShiftExpr([NotNull] Z80TestParser.ShiftExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.shiftExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShiftExpr([NotNull] Z80TestParser.ShiftExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.addExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddExpr([NotNull] Z80TestParser.AddExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.addExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddExpr([NotNull] Z80TestParser.AddExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.multExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultExpr([NotNull] Z80TestParser.MultExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.multExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultExpr([NotNull] Z80TestParser.MultExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.unaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpr([NotNull] Z80TestParser.UnaryExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.unaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpr([NotNull] Z80TestParser.UnaryExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.literalExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralExpr([NotNull] Z80TestParser.LiteralExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.literalExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralExpr([NotNull] Z80TestParser.LiteralExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.symbolExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSymbolExpr([NotNull] Z80TestParser.SymbolExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.symbolExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSymbolExpr([NotNull] Z80TestParser.SymbolExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.registerSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRegisterSpec([NotNull] Z80TestParser.RegisterSpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.registerSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRegisterSpec([NotNull] Z80TestParser.RegisterSpecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.addrSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddrSpec([NotNull] Z80TestParser.AddrSpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.addrSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddrSpec([NotNull] Z80TestParser.AddrSpecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.reachSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReachSpec([NotNull] Z80TestParser.ReachSpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.reachSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReachSpec([NotNull] Z80TestParser.ReachSpecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.memReadSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemReadSpec([NotNull] Z80TestParser.MemReadSpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.memReadSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemReadSpec([NotNull] Z80TestParser.MemReadSpecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Z80TestParser.memWriteSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemWriteSpec([NotNull] Z80TestParser.MemWriteSpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Z80TestParser.memWriteSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemWriteSpec([NotNull] Z80TestParser.MemWriteSpecContext context);
}
} // namespace Spect.Net.TestParser.Generated

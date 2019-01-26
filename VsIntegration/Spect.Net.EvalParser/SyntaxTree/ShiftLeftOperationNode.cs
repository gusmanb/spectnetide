﻿namespace Spect.Net.EvalParser.SyntaxTree
{
    /// <summary>
    /// This class represents the add operation
    /// </summary>
    public sealed class ShiftLeftOperationNode : BinaryOperationNode
    {
        /// <summary>
        /// Calculates the result of the binary operation.
        /// </summary>
        /// <param name="evalContext">Evaluation context</param>
        /// <returns>Result of the operation</returns>
        public override ExpressionValue Calculate(IExpressionEvaluationContext evalContext)
        {
            var left = LeftOperand.Evaluate(evalContext);
            var right = RightOperand.Evaluate(evalContext);
            return left.IsValid && right.IsValid
                ? new ExpressionValue(left.Value << (int)right.Value)
                : ExpressionValue.Error;
        }
    }
}
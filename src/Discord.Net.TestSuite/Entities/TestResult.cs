using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;

namespace Discord.TestSuite
{
    public sealed class TestResult : IResult
    {
        private readonly IResult _inner;

        public CommandError? Error { get; }
        public string ErrorReason { get; }
        public bool IsSuccess => Error == null;

        public ICommandContext Context { get; }
        public IUserMessage Reply { get; }

        private TestResult(TestCommandContext context, IResult innerResult)
        {
            _inner = innerResult;
            Error = _inner.Error;
            ErrorReason = _inner.ErrorReason;
            Context = context;
            Reply = context.Reply;
        }

        private TestResult(ICommandContext context, string errorReason)
        {
            Error = CommandError.Unsuccessful;
            ErrorReason = errorReason;
            Context = context;
        }

        internal static TestResult FromCommandResult(TestCommandContext ctx, IResult result)
            => new TestResult(ctx, result);

        public static TestResult FromError(ICommandContext context, string errorReason)
            => new TestResult(context, errorReason);
    }
}

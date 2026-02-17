using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace CSharpFunctionalExtensions.Tests.ResultTests.Extensions
{
    public class TapErrorIfTests_Task : TapErrorIfTestsBase
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_executes_action_conditionally_and_returns_self(bool isSuccess, bool condition)
        {
            Result result = Result.SuccessIf(isSuccess, ErrorMessage);

            var returned = await result.AsTask().TapErrorIf(condition, Task_Action);

            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_executes_action_String_conditionally_and_returns_self(bool isSuccess, bool condition)
        {
            Result result = Result.SuccessIf(isSuccess, ErrorMessage);

            var returned = await result.AsTask().TapErrorIf(condition, Task_Action_String);

            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_T_executes_action_conditionally_and_returns_self(bool isSuccess, bool condition)
        {
            Result<T> result = Result.SuccessIf(isSuccess, T.Value, ErrorMessage);

            var returned = await result.AsTask().TapErrorIf(condition, Task_Action);

            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_T_executes_action_T_conditionally_and_returns_self(bool isSuccess, bool condition)
        {
            Result<T> result = Result.SuccessIf(isSuccess, T.Value, ErrorMessage);

            var returned = await result.AsTask().TapErrorIf(condition, Task_Action_String);

            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_T_E_executes_action_conditionally_and_returns_self(bool isSuccess, bool condition)
        {
            Result<T, E> result = Result.SuccessIf(isSuccess, T.Value, E.Value);

            var returned = await result.AsTask().TapErrorIf(condition, Task_Action);

            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_T_E_executes_action_T_conditionally_and_returns_self(bool isSuccess, bool condition)
        {
            Result<T, E> result = Result.SuccessIf(isSuccess, T.Value, E.Value);

            var returned = await result.AsTask().TapErrorIf(condition, Task_Action_E);

            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_E_executes_action_conditionally_and_returns_self(bool isSuccess, bool condition)
        {
            UnitResult<E> result = UnitResult.SuccessIf(isSuccess, E.Value);

            var returned = await result.AsTask().TapErrorIf(condition, Task_Action);

            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_E_executes_action_T_conditionally_and_returns_self(bool isSuccess, bool condition)
        {
            UnitResult<E> result = UnitResult.SuccessIf(isSuccess, E.Value);

            var returned = await result.AsTask().TapErrorIf(condition, Task_Action_E);

            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_executes_action_per_predicate_and_returns_self(bool isSuccess, bool condition)
        {
            Result result = Result.SuccessIf(isSuccess, ErrorMessage);

            var returned = await result.AsTask().TapErrorIf(Predicate_String(condition), Task_Action);

            predicateExecuted.Should().Be(!isSuccess);
            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_executes_action_String_per_predicate_and_returns_self(bool isSuccess, bool condition)
        {
            Result result = Result.SuccessIf(isSuccess, ErrorMessage);

            var returned = await result.AsTask().TapErrorIf(Predicate_String(condition), Task_Action_String);

            predicateExecuted.Should().Be(!isSuccess);
            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_T_executes_action_per_predicate_and_returns_self(bool isSuccess, bool condition)
        {
            Result<T> result = Result.SuccessIf(isSuccess, T.Value, ErrorMessage);

            var returned = await result.AsTask().TapErrorIf(Predicate_String(condition), Task_Action);

            predicateExecuted.Should().Be(!isSuccess);
            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_T_executes_action_String_per_predicate_and_returns_self(bool isSuccess, bool condition)
        {
            Result<T> result = Result.SuccessIf(isSuccess, T.Value, ErrorMessage);

            var returned = await result.AsTask().TapErrorIf(Predicate_String(condition), Task_Action_String);

            predicateExecuted.Should().Be(!isSuccess);
            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_T_E_executes_action_per_predicate_and_returns_self(bool isSuccess, bool condition)
        {
            Result<T, E> result = Result.SuccessIf(isSuccess, T.Value, E.Value);

            var returned = await result.AsTask().TapErrorIf(Predicate_E(condition), Task_Action);

            predicateExecuted.Should().Be(!isSuccess);
            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_T_E_executes_action_E_per_predicate_and_returns_self(bool isSuccess, bool condition)
        {
            Result<T, E> result = Result.SuccessIf(isSuccess, T.Value, E.Value);

            var returned = await result.AsTask().TapErrorIf(Predicate_E(condition), Task_Action_E);

            predicateExecuted.Should().Be(!isSuccess);
            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_E_executes_action_per_predicate_and_returns_self(bool isSuccess, bool condition)
        {
            UnitResult<E> result = UnitResult.SuccessIf(isSuccess, E.Value);

            var returned = await result.AsTask().TapErrorIf(Predicate_E(condition), Task_Action);

            predicateExecuted.Should().Be(!isSuccess);
            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public async Task TapErrorIf_Task_E_executes_action_E_per_predicate_and_returns_self(bool isSuccess, bool condition)
        {
            UnitResult<E> result = UnitResult.SuccessIf(isSuccess, E.Value);

            var returned = await result.AsTask().TapErrorIf(Predicate_E(condition), Task_Action_E);

            predicateExecuted.Should().Be(!isSuccess);
            actionExecuted.Should().Be(!isSuccess && condition);
            result.Should().Be(returned);
        }
    }
}

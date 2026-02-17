using System.Threading.Tasks;

namespace CSharpFunctionalExtensions.ValueTasks
{
    internal static class ValueTaskExtensions
    {
        public static ValueTask<T> AsCompletedValueTask<T>(this T obj) => ValueTask.FromResult(obj);
    }
}

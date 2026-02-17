using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace CSharpFunctionalExtensions
{
    partial struct Result
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetError(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out string error)
        {
            error = _error;
            return IsFailure;
        }
    }

    partial struct Result<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetValue(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out T value)
        {
            value = _value;
            return IsSuccess;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetError(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out string error)
        {
            error = _error;
            return IsFailure;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetValue(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out T value,
            [NotNullWhen(false), MaybeNullWhen(true)]
            out string error
            )
        {
            value = _value;
            error = _error;
            return IsSuccess;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetError(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out string error,
            [NotNullWhen(false), MaybeNullWhen(true)]
            out T value
            )
        {
            value = _value;
            error = _error;
            return IsFailure;
        }
    }

    partial struct Result<T, E>
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetValue(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out T value)
        {
            value = _value;
            return IsSuccess;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetError(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out E error)
        {
            error = _error;
            return IsFailure;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetValue(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out T value,
            [NotNullWhen(false), MaybeNullWhen(true)]
            out E error
        )
        {
            value = _value;
            error = _error;
            return IsSuccess;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetError(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out E error,
            [NotNullWhen(false), MaybeNullWhen(true)]
            out T value
        )
        {
            value = _value;
            error = _error;
            return IsFailure;
        }
    }

    partial struct UnitResult<E>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetError(
            [NotNullWhen(true), MaybeNullWhen(false)]
            out E error)
        {
            error = _error;
            return IsFailure;
        }
    }
}

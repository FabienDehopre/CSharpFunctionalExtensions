using System.Collections.Generic;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static Maybe<V> TryFind<K, V>(this IReadOnlyDictionary<K, V> dict, K key)
        {
            if (dict.ContainsKey(key))
            {
                return dict[key];
            }
            return Maybe<V>.None;
        }
    }
}

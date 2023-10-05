namespace FkUtil.Extensions
{
    /// <summary>
    /// This class contains extension methods for <see cref="IDictionary{TKey, TValue}"/> 
    /// </summary>
    public static class IDictionaryExtensions
    {
        /// <summary>
        /// Adds a value to a collection in a dictionary.
        /// If the dictionary already contains the key the collection is extended
        /// If the dictionary does not contain the key, the collection is created beforhand
        /// </summary>
        /// <typeparam name="TKey">Type of the dicitionary key (or index)</typeparam>
        /// <typeparam name="TCollection">Type of the collection the dictionary indexes</typeparam>
        /// <typeparam name="TValue">Type of the values inside the collections</typeparam>
        /// <param name="dict">The dictionary to add to</param>
        /// <param name="key">The key to add the value to</param>
        /// <param name="newVal">The new value</param>
        public static void AddOrExtendCollection<TKey,TCollection,TValue>(this IDictionary<TKey,TCollection> dict,TKey key, TValue newVal) where TCollection : ICollection<TValue>, new()
        {
            if (!dict.TryGetValue(key, out var collection))
            {
                collection = new TCollection();
                dict.Add(key, collection);
            }

            collection.Add(newVal);
        }

    }
}

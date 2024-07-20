using FkUtil.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FkUtil.Test.Extensions
{

    /// <summary>
    /// Tests for <see cref="IDictionaryExtensions"/>
    /// </summary>
    [TestClass]
    public class IDictionaryExtensionsTest
    {
        /// <summary>
        /// Tests <see cref="IDictionaryExtensions.AddOrExtendCollection{TKey, TCollection, TValue}(IDictionary{TKey, TCollection}, TKey, TValue)"/>
        /// </summary>
        [TestMethod]
        public void AddOrExtendCollectionTest() { 

            var dictUnderTest = new Dictionary<string,List<string>>();

            //Test empty add
            dictUnderTest.AddOrExtendCollection("firstKey", "firstEntry");

            Assert.AreEqual(dictUnderTest["firstKey"][0], "firstEntry");

            //Test add on existing key
            dictUnderTest.AddOrExtendCollection("firstKey", "secondEntry");

            CollectionAssert.AreEquivalent(dictUnderTest["firstKey"], new List<string> { "firstEntry", "secondEntry" });

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_LRUCache
    {
        [Medium]
        [TestMethod]
        public void Should_Evict_Old_Cache()
        {
            // arrange
            var cache = new LRUCache(2);

            // act
            cache.Put(1, 1);
            cache.Put(2, 2);

            // assert
            Assert.AreEqual(1, cache.Get(1), "key 1 exists");

            cache.Put(3, 3);
            Assert.AreEqual(-1, cache.Get(2), "key 2 evicted");

            cache.Put(4, 4);
            Assert.AreEqual(-1, cache.Get(1), "key 1 evicted");
            Assert.AreEqual(3, cache.Get(3), "key 3 exists");
            Assert.AreEqual(4, cache.Get(4), "key 4 exists");
        }


        /// <summary>
        /// Least Recently Used (LRU) cache
        /// </summary>
        /// <remarks>
        /// Cache relacment policy to discard the least recently used items first
        /// </remarks>
        public class LRUCache
        {
            /// <summary>
            /// Value Constructor
            /// </summary>
            /// <param name="capacity">size of cache</param>
            public LRUCache(int capacity)
            {
            }

            /// <summary>
            /// Returns always positive cache value if exists, otherwise -1
            /// </summary>
            /// <param name="key"></param>
            /// <returns>-1 if does not exist</returns>
            public int Get(int key)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Set or insert cache value
            /// </summary>
            /// <param name="key"></param>
            /// <param name="value"></param>
            public void Put(int key, int value)
            {
                // should invalidate the least recently used item before inserting a new item

                throw new NotImplementedException();
            }
        }
    }
}

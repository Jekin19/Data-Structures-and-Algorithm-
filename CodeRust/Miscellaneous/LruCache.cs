using System;
using System.Collections.Generic;
namespace CodeRust.Miscellaneous
{
    public class LruCache<T,V>
    {
        Dictionary<T, string> dict = new Dictionary<T, string>();
        int capacity = 0;
        LinkedList<T> linkedList = new LinkedList<T>();

        public LruCache(int capacity) {
            this.capacity = capacity;
        }

        public string GetOrAdd(T key) {

            Console.WriteLine("Get or Add Key " + key);
            // If you have key in cache
            if (dict.ContainsKey(key)) {
                Console.WriteLine(string.Format("Found key {0} in cache value is {1}", key, dict[key]));
                AdjustCache(key);
            } 
            else 
            {
                // If full just remove first
                if (dict.Count == capacity)
                {
                    Console.WriteLine(string.Format("Capacity full so removing key {0} ", linkedList.First.Value));
                    dict.Remove(linkedList.First.Value);
                    linkedList.RemoveFirst();
                }
                linkedList.AddLast(key);
                dict.Add(key, key.ToString());
                Console.WriteLine(string.Format("Adding key {0} ", key));

            }
            foreach(var link in linkedList) {
                Console.Write(link + "=> ");
            }
            Console.WriteLine();
            return dict[key];
        }

        private void AdjustCache(T key) {
            linkedList.Remove(key);
            linkedList.AddLast(key);
        }
    }
    public class LruCacheTester {

        public static void TestMethod()
        {
            var lru = new LruCache<int, string>(4);
            lru.GetOrAdd(1);
            lru.GetOrAdd(2);
            lru.GetOrAdd(3);
            lru.GetOrAdd(1);
            lru.GetOrAdd(4);
            lru.GetOrAdd(5);
            lru.GetOrAdd(5);
            lru.GetOrAdd(2);
            lru.GetOrAdd(6);
            lru.GetOrAdd(7);
            lru.GetOrAdd(8);
        }
    }

   
}

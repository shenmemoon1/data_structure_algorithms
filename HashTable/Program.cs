using System;
using System.Collections.Generic;

namespace HashTable
{
    //键值对 int->string
     public class Pair
    {
        public int key;
        public string value;
        public Pair(int k, string val)
        {
            key = k;
            value = val;
        }
    }


    //基于数组实现哈希表
    public class HashTable
    {
        private List<Pair?> buckets;
        public HashTable()
        {
            //initial 100 buckets
            buckets = new();
            for(int i = 0; i<100; i++)
            {
                buckets.Add(null);
            }
        }

        //hash fucntion
        public int HashF(int key)
        {
            int index = key % 100;
            return index;
        }

        //添加操作
        public void put(int key, string val)
        {
            int index = HashF(key);
            Pair pair = new(key, val);
            buckets[index] = pair;
        }

        //查询操作
        public string? get(int key)
        {
            //获取在List的index
            int index = HashF(key);
            Pair? pair = buckets[index];
            if (pair == null) return null;
            return pair.value;
        }

        //删除操作
        public void remove(int key)
        {
            int index = HashF(key);
            buckets[index] = null;
        }

        //获取所有键
        public List<int> keySet()
        {
            List<int> keySet = new();
            foreach(Pair? pair in buckets)
            {
                if(pair != null)
                {
                    keySet.Add(pair.key);
                }
            }

            return keySet;
        }

        //获取所有的value set
        public List<string> valueSet()
        {
            List<string> valueSet = new();
            foreach (Pair? pair in buckets)
            {
                if (pair != null)
                {
                    valueSet.Add(pair.value);
                }
            }

            return valueSet;
        }

        //打印哈希表
        public void print()
        {
            foreach(Pair? pair in buckets)
            {
                if(pair !=null)
                    Console.WriteLine($"{pair.key} -> {pair.value}");
            }
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable();
            hashTable.put(20336, "David");
            hashTable.put(12836, "Kevin");
            hashTable.put(48693, "Lilly");
            hashTable.print();
        }
    }
}

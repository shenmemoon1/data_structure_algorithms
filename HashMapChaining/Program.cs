using System;
using System.Collections.Generic;

namespace HashMapChaining
{
    class Program
    {
        //键值对
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

        //链式地址哈希表

        public class HashTableChaining
        {
            int size;
            int capacity;
            double loadThres;
            int extendRatio;
            List<List<Pair>> buckets;

            public HashTableChaining()
            {
                size = 0;
                capacity = 4;
                loadThres = 2 / 3.0;
                extendRatio = 2;
                buckets = new List<List<Pair>>();
                for (int i = 0; i < capacity; i++)
                {
                    buckets.Add(new List<Pair>());
                }
            }

            //hash函数
            private int hashFunc(int key)
            {
                return key % capacity;
            }

            //负载因子
            private double loadFactor()
            {
                return (double)size / capacity;
            }

            //查询操作
            public string get(int key)
            {
                int index = hashFunc(key);
                foreach (Pair pair in buckets[index])
                {
                    if (pair.key == key)
                    {
                        return pair.value;
                    }
                }

                return null;
            }

            //添加操作
            public void put(int k, string val)
            {
                if (loadFactor() > loadThres)
                {
                    extend();
                }

                int index = hashFunc(k);
                // 遍历桶，若遇到指定 key ，则更新对应 val 并返回
                foreach (Pair p in buckets[index])
                {
                    if(p.key == k)
                    {
                        p.value = val;
                        return;
                    }
                }

                //如果没有K 添加至尾部
                buckets[index].Add(new Pair(k, val));
                size++;

            }

            //删除操作
            public void remove(int key)
            {
                int index = hashFunc(key);
                foreach(Pair p in buckets[index])
                {
                    if(p.key == key)
                    {
                        buckets[index].Remove(p);
                        size--;
                        break;
                    }
                }
            }

            //扩张
            public void extend()
            {
                //暂存hashtable
                List<List<Pair>> tempHash = buckets;
                //初始化新的哈希表
                capacity *= extendRatio;
                buckets = new List<List<Pair>>(capacity);
                for(int i=0; i<capacity; i++)
                {
                    buckets.Add(new List<Pair>());
                }

                size = 0;
                //将键值对搬到新的哈希表
                foreach(List<Pair> bucket in tempHash)
                {
                    foreach (Pair pair in bucket)
                    {
                        put(pair.key, pair.value);
                    }
                }
            }

            /* 打印哈希表 */
            public void print()
            {
                foreach (List<Pair> bucket in buckets)
                {
                    List<string> res = new List<string>();
                    foreach (Pair pair in bucket)
                    {
                        res.Add(pair.key + " -> " + pair.value);
                    }
                    foreach (string kv in res)
                    {
                        Console.WriteLine(kv);
                    }
                }
            }

        }



        static void Main(string[] args)
        {
            HashTableChaining hashTableChaining = new HashTableChaining();
            hashTableChaining.put(12345, "David");
            hashTableChaining.put(12348, "Lilly");
            hashTableChaining.put(12375, "Kevin");

            hashTableChaining.print();
        }
    }
}

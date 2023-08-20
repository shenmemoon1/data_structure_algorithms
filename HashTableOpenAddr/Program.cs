using System;

namespace HashTableOpenAddr
{
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

    class HashTableOpen
    {
        int size; // 键值对数量
        int capacity; // 哈希表容量
        double loadThres; // 触发扩容的负载因子阈值
        int extendRatio; // 扩容倍数
        Pair[] buckets; // 桶数组
        Pair removed; // 删除标记

        /* 构造方法 */
        public HashTableOpen()
        {
            size = 0;
            capacity = 4;
            loadThres = 2.0 / 3.0;
            extendRatio = 2;
            buckets = new Pair[capacity];
            removed = new Pair(-1, "-1");

        }


        private int hashFunc(int key)
        {
            return key % 100;
        }

        /* 负载因子 */
        private double loadFactor()
        {
            return (double)size / capacity;
        }

        /* 扩容哈希表 */
        private void extend()
        {
            // 暂存原哈希表
            Pair[] bucketsTmp = buckets;
            // 初始化扩容后的新哈希表
            capacity *= extendRatio;
            buckets = new Pair[capacity];
            size = 0;
            // 将键值对从原哈希表搬运至新哈希表
            foreach (Pair pair in bucketsTmp)
            {
                if (pair != null && pair != removed)
                {
                    put(pair.key, pair.value);
                }
            }
        }

        public string get(int key)
        {
            int index = hashFunc(key);
            for (int i = 0; i < capacity; i++)
            {
                //计算index 越过尾部返回头部
                int j = (index + 1) % capacity;
                if (buckets[index] ==null)
                { 
                    return null;
                }

                //get value
                if (buckets[j].key == key && buckets[j]!=removed)
                {
                    return buckets[j].value;
                }
            }

            return null;
        }


        /* 添加操作 */
        public void put(int key, string val)
        {
            // 当负载因子超过阈值时，执行扩容
            if (loadFactor() > loadThres)
            {
                extend();
            }
            int index = hashFunc(key);
            // 线性探测，从 index 开始向后遍历
            for (int i = 0; i < capacity; i++)
            {
                // 计算桶索引，越过尾部返回头部
                int j = (index + i) % capacity;
                // 若遇到空桶、或带有删除标记的桶，则将键值对放入该桶
                if (buckets[j] == null || buckets[j] == removed)
                {
                    buckets[j] = new Pair(key, val);
                    size += 1;
                    return;
                }
                // 若遇到指定 key ，则更新对应 val
                if (buckets[j].key == key)
                {
                    buckets[j].value = val;
                    return;
                }
            }
        }


        /* 删除操作 */
        public void remove(int key)
        {
            int index = hashFunc(key);
            // 线性探测，从 index 开始向后遍历
            for (int i = 0; i < capacity; i++)
            {
                // 计算桶索引，越过尾部返回头部
                int j = (index + i) % capacity;
                // 若遇到空桶，说明无此 key ，则直接返回
                if (buckets[j] == null)
                {
                    return;
                }
                // 若遇到指定 key ，则标记删除并返回
                if (buckets[j].key == key)
                {
                    buckets[j] = removed;
                    size -= 1;
                    return;
                }
            }
        }

        /* 打印哈希表 */
        public void print()
        {
            foreach (Pair pair in buckets)
            {
                if (pair != null)
                {
                    Console.WriteLine(pair.key + " -> " + pair.value);
                }
                else
                {
                    Console.WriteLine("null");
                }
            }
        }

    }
    

    class Program
    {
       
      
        static void Main(string[] args)
        {
            HashTableOpen hashTableOpen = new HashTableOpen();
            hashTableOpen.put(123, "David");
            hashTableOpen.put(163, "John");
            hashTableOpen.put(143, "Kevin");

            hashTableOpen.print();
        }
    }
}

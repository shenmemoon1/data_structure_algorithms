using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableOpenAddr
{
    class HashFuncDesign
    {
        /* 加法哈希 */
        int addHash(string key)
        {
            long hash = 0;
            const int MODULUS = 1000000007;
            foreach (char c in key)
            {
                hash = (hash + c) % MODULUS;
            }
            return (int)hash;
        }

        /* 乘法哈希 */
        int mulHash(string key)
        {
            long hash = 0;
            const int MODULUS = 1000000007;
            foreach (char c in key)
            {
                hash = (31 * hash + c) % MODULUS;
            }
            return (int)hash;
        }

        /* 异或哈希 */
        int xorHash(string key)
        {
            int hash = 0;
            const int MODULUS = 1000000007;
            foreach (char c in key)
            {
                hash ^= c;
            }
            return hash & MODULUS;
        }

        /* 旋转哈希 */
        int rotHash(string key)
        {
            long hash = 0;
            const int MODULUS = 1000000007;
            foreach (char c in key)
            {
                hash = ((hash << 4) ^ (hash >> 28) ^ c) % MODULUS;
            }
            return (int)hash;
        }

    }
}

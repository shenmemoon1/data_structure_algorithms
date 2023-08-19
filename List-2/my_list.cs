using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2
{
    class my_list
    {
        private int[] nums;
        private int numsCapcity = 10;
        private int numsSize = 0;
        private int extendRatio = 2;

        public my_list()
        {
            nums = new int[numsCapcity];
        }

        public int Size()
        {
            return numsSize;
        }

        public int Capcity()
        {
            return numsCapcity;
        }

        //访问元素
        public int Get(int index)
        {
            if (index < 0 || index >= numsSize)
            {
                throw new IndexOutOfRangeException("索引越界");
            }
            return nums[index];
        }

        //更新元素
        public void set(int index, int value)
        {
            if (index < 0 || index >= numsSize)
            {
                throw new IndexOutOfRangeException("索引越界");
            }
            nums[index] = value;
        }

        /* 列表扩容 */
        public void extendCapacity()
        {
            // 新建一个长度为 numsCapacity * extendRatio 的数组，并将原数组拷贝到新数组
            Array.Resize(ref nums, numsCapcity * extendRatio);
            // 更新列表容量
            numsCapcity = nums.Length;
        }

        //添加元素
        public void Add(int value)
        {
            if(numsSize == numsCapcity)
            {
                extendCapacity();
            }
            nums[numsSize] = value;
            numsSize++;
        }


        /* 删除元素 */
        public int remove(int index)
        {
            if (index < 0 || index >= numsSize)
                throw new IndexOutOfRangeException("索引越界");
            int num = nums[index];
            // 将索引 index 之后的元素都向前移动一位
            for (int j = index; j < numsSize - 1; j++)
            {
                nums[j] = nums[j + 1];
            }
            // 更新元素数量
            numsSize--;
            // 返回被删除元素
            return num;
        }

        /* 将列表转换为数组 */
        public int[] toArray()
        {
            // 仅转换有效长度范围内的列表元素
            int[] nums = new int[numsSize];
            for (int i = 0; i < numsSize; i++)
            {
                nums[i] = Get(i);
            }
            return nums;
        }
    }
}

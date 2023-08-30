using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class FindKValueHeap
    {
        public List<int> nums;
        public FindKValueHeap()
        {
            nums = new List<int> { 1, 7, 6, 3, 2 };
        }

        public List<int> find(int k)
        {
            /* 基于堆查找数组中最大的 k 个元素 */
            List<int> kList = new List<int>();
            for (int i = 0; i < k; i++)
            {
                // 将数组的前 k 个元素入堆
                kList.Add(nums[i]);
            }

            // 从第 k+1 个元素开始，保持堆的长度为 k
            for (int i = k; i < nums.Count; i++)
            {
                // 若当前元素大于堆顶元素，则将堆顶元素出堆、当前元素入堆
                if (nums[i] > kList[0])
                {
                    kList.RemoveAt(0);
                    kList.Add(nums[i]);
                }
            }
            return kList;

        }

    }
}

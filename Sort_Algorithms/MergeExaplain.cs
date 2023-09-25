using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class MergeExaplain
    {
        public static void MergeE(int[] nums)
        {
            //创建一个方法用于递归分裂数组
            MergeSepeare(nums, 0, nums.Length - 1);
        }

        private static void MergeSepeare(int[] nums, int left, int right)
        {
            //中止条件， 当只有一个元素直接返回
            if (left >= right) return;
            //设置中间值 用于分裂
            int mid = (left + right) / 2;
            //开始分裂左边
            //start-----Mid
            MergeSepeare(nums, left, mid);
            //开始分裂右侧
            //Mid----end
            MergeSepeare(nums, mid + 1, right);

            //当分裂到每个单个元素 开始合并
            MergeTogh(nums, left, mid, right);
        }

        private static void MergeTogh(int[] nums, int left, int mid, int right)
        {
            //复制nums那个区段的数组
            int[] tmp = nums[left..(right + 1)];
            //设置游标 然后左右滑动
            int leftStart = left - left, leftEnd = mid - left, rightStart = mid + 1 - left, rightEnd = right - left;
            //如下
            //左侧是[4] 右侧数组是[7]
            //开始判断
            for (int k = left; k <= right; k++)
            {
                //这个时候 左侧是0 并且在>end的时候代表左侧数组结束 那么直接添加右侧数组到nums
                if (leftStart > leftEnd) nums[k] = tmp[rightStart++];
                //右侧数组结束 或者说tmp[i]<tmp[j] 这个时候 就把左侧数组加入Nums 并且i++ 滑动到下一个数组元素
                else if (rightStart > rightEnd || tmp[leftStart] <= tmp[rightStart]) nums[k] = tmp[leftStart++];
                //最后 只有一个情况 单每个元素都在他自己数组的第一位 并且右侧数组第一个元素小于左侧数组
                else nums[k] = tmp[rightStart++];

            }
        }
    }
}

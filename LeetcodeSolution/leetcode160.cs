using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class leetcode160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            //使用set来保存唯一
            HashSet<ListNode> set = new HashSet<ListNode>();
            ListNode curr = headA;
            //保存所有A的值
            while (curr != null)
            {
                set.Add(curr);
                curr = curr.next;
            }
            //查询A里面是否有B的内存地址
            ListNode b = headB;
            while (b != null)
            {
                if (set.Contains(b))
                {
                    return b;
                }
                b = b.next;
            }

            return null;
        }
    }
}

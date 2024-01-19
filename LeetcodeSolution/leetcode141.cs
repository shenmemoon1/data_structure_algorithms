using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class leetcode141
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            ListNode curr = head;

            while (curr != null)
            {
                if (set.Contains(curr))
                {
                    return true;
                }
                else
                {
                    set.Add(curr);
                }

                curr = curr.next;
            }

            return false;
        }
    }
}

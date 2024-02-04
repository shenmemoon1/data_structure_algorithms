using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode234
    {
        public static bool IsPalindrome(ListNode head)
        {
            List<int> list = new List<int>();
            ListNode curr = head;
            while (curr != null)
            {
                list.Add(curr.val);
                curr = curr.next;
            }

            int i = 0, j = list.Count - 1;
            while (i < j)
            {
                if (list[i] != list[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
    }
}

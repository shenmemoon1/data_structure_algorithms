using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode206
    {
        public static ListNode ReverseList(ListNode head)
        {
            List<int> nodeList = new List<int>();
            ListNode fake = new ListNode();
            ListNode curr = head;
            ListNode hel = fake;

            while (curr != null)
            {
                nodeList.Add(curr.val);
                curr = curr.next;
            }

            for (int i = nodeList.Count - 1; i >= 0; i--)
            {
                ListNode node = new(nodeList[i]);
                hel.next = node;
                hel = hel.next;
            }

            return fake.next;
        }
    }
}

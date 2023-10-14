using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class Leetcode23MergekSortedLists
    {   
        //合并K个sort的链表
        /*
         * 我的解题思路：
         * 第一点使用上分而治之
         * 首先把它看成一个普通数据
         * 边界就是当只剩下一个数组 这个时候直接返回 
         * 处理left>right 的情况 也就是right那一边
         * 先分解剩下独立的数组 然后返回
         * 这个时候把他们merge到一个数组， 需要对比两个链表里面元素的大小
         * 比较过程如下
         * 如果A节点《B节点那么 A自然再前面 B就得和A的next节点比较 
         * 不停这个过程
         */
        public static ListNode MergeKLists(ListNode[] lists)
        {
            return MergeSp(0, lists.Length - 1, lists);
        }

        private static ListNode MergeSp(int left, int right, ListNode[] lists)
        {
            if (left == right)
            {
                return lists[left];
            }
            if (left > right)
            { // 处理 left > right 的情况
                return null;
            }

            int mid = (left + right) / 2;

            ListNode leftList = MergeSp(left, mid, lists);
            ListNode rightList = MergeSp(mid + 1, right, lists);

            return Merge(leftList, rightList);
        }

        private static ListNode Merge(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            if (list1.val < list2.val)
            {
                list1.next = Merge(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = Merge(list1, list2.next);
                return list2;
            }
        }
    }
}

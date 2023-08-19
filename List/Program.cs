using System;

namespace List
{
    public class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode(int x) => value = x;
    }

    class Linked_list
    {
        public static void Insert(ListNode n0, ListNode p)
        {
            ListNode? n1 = n0.next;
            p.next = n1;
            n0.next = p;
        }

        public static void PrintList(ListNode head)
        {
            ListNode current = head;
            while(current != null)
            {
                Console.Write($"{current.value} ");
                current = current.next;
            }
            Console.WriteLine();
        }

        public static void Remove(ListNode node)
        {
            if(node.next == null)
            {
                return;
            }
            //2->x->5
            ListNode p = node.next;
            ListNode? n1 = p.next;
            node.next = n1;
        }

        public static ListNode? Access(ListNode head, int index)
        {
            for (int i = 0; i < index; i++)
            {
                if(head.next == null)
                    return null;
                head = head.next;

            }
            return head;
        }

        public static int Find(ListNode head, int target)
        {
            int index = 0;
            while(head.value != target)
            {
                head = head.next;
                index++;
            }

            return index;
        }

        public static void Main()
        {
            // 初始化链表 
            // 初始化各个节点 
            ListNode n0 = new(1);
            ListNode n1 = new(3);
            ListNode n2 = new(2);
            ListNode n3 = new(5);
            ListNode n4 = new(4);
            // 构建引用指向
            n0.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;

            PrintList(n0);

            // 插入节点 
            /*Insert(n0, new ListNode(0));
            PrintList(n0);*/

            /*Remove(n1);*/
            /*ListNode a1=  Access(n0, 2);
            Console.WriteLine(a1.value);*/

            int nodeIndex = Find(n0, 5);
            Console.WriteLine(nodeIndex);
        }
    }
}

using System;

namespace ArrayDeque
{

    public class Dequeue
    {
        private readonly int[] nums;
        private int front;
        private int deqSize;
        public Dequeue(int capcity)
        {
            nums = new int[capcity];
            front = deqSize = 0;
        }

        public int Capcity()
        {
            return nums.Length;
        }


        public int Size()
        {
            return deqSize;
        }

        private int Index(int i)
        {
            return (i + Capcity()) % Capcity();
        }

        public void PushFirst(int num)
        {
           if(deqSize == Capcity())
            {
                Console.WriteLine("nums array full");
            }

            front = Index(front - 1);
            nums[front] = num;
            deqSize++;//2

        }

        public void PushLast(int num)
        {
            if(deqSize == Capcity())
            {
                Console.WriteLine("num array full");
            }

            int rear = Index(front + deqSize);
            nums[rear] = num;
            deqSize++;
        }


        public int PeekFirst()
        {
            return nums[front];

        }

        public int PopFirst()
        {
            int num = PeekFirst(); //88
            front = Index(front + 1); //-2
            deqSize--;
            return num;
        }

        public int PopLast()
        {
            int last = PeekLast();
            deqSize--;
            return last;
        }



        public int PeekLast()
        {//-1
            int last = Index(front + deqSize - 1);
            return nums[last];
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Dequeue dequeue = new Dequeue(5);
            dequeue.PushFirst(1);//-2
            dequeue.PushFirst(55);//-2
            dequeue.PushFirst(88);//-3
            dequeue.PushLast(9); //0
            dequeue.PushLast(5);//1
            dequeue.PushLast(33);//2 == -3 len = nums.Length = 5
            Console.WriteLine(dequeue.PeekLast());
            Console.WriteLine(dequeue.PeekFirst());
            
            
        }
    }
}

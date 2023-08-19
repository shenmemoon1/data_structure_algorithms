using System;

namespace ArrayQue
{
    public class ArrayQueue
    {
        private int[] nums;
        private int front;
        private int queSize;


        public ArrayQueue(int capcity)
        {
            nums = new int[capcity];
            front = queSize = 0;
        }

        public int Capcity()
        {
            return nums.Length;
        }
        
        public int Size()
        {
            return queSize;
        }

        public bool IsEmpty()
        {
            return queSize == 0;
        }

        //入列
        public void Push(int num)
        {
            if(queSize == Capcity())
            {
                Console.WriteLine("Queue full");
                return;
            }
            //计算尾指针 指向队尾+1
            //取余 越过尾部到头部
            int rear = (front + queSize) % Capcity();

            //将num 添加到队尾
            nums[rear] = num;
            queSize++; 

        }

        public int Pop()
        {
            int num = Peek(); //Font value
            //front 加一 逻辑上是环形
            front = (front + 1) % Capcity();
            queSize--;
            return num;
        }

        public int Peek()
        {
            return nums[front];
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQueue que = new ArrayQueue(5);
            que.Push(33);
            que.Push(55);
            que.Push(99);
            Console.WriteLine(que.Peek());
        }
    }
}

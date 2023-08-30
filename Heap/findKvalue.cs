using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class FindKvalue
    {
        List<int> Arr;
        //method 1 => i traveral
        public FindKvalue(List<int> arr)
        {
            Arr = arr;
        }

        public List<int> findkMax(int k)
        {
            List<int> list = new();
            int max = 0;
            int len = 0;
            while (len < Arr.Count)
            {
                for (int i = len + 1; i < Arr.Count; i++)
                {
                    if (Arr[max] < Arr[i])
                    {
                        max = i;
                       

                        // 3
                    }

                }

                if (list.Count <= 3)
                {
                    list.Add(Arr[max]);
                    Arr.RemoveAt(max);
                }
                else
                {
                    break;
                }
                len++;
            }
            return list;
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    class BagValue
    {
        /*
         * 假设有一个背包，最大容量为 C，有一些物品，
         * 每个物品有自己的重量 w 和价值 v。我们的目标是在背包容量不超过 C 的情况下，
         * 选择一些物品放入背包，使得背包中物品的总价值最大。
         */

        public class Item
        {
            public int Value { get; set; }
            public int Weight { get; set; }
            public double UnitValue { get; set; }

            public Item(int value, int weight)
            {
                this.Value = value;
                this.Weight = weight;
                UnitValue = (double)value / weight;
            }
        }

        public static double ValueWeight(Item[] items, int capacity)
        {
            if (capacity == 0) return 0;
            Array.Sort(items, (x, y) => y.UnitValue.CompareTo(x.UnitValue));

            double totalValue = 0;
            int remainingCapcity = capacity;

            foreach (Item item in items)
            {
                if(remainingCapcity - item.Weight >= 0)
                {
                    totalValue += item.Value;
                    remainingCapcity -= item.Weight;
                }
            }

            return totalValue;


        }
    }
}

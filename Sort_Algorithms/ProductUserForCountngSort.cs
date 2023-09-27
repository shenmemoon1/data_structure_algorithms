using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class ProductUserForCountngSort
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public ProductUserForCountngSort(int price, string name) => (Price, Name) = (price, name);
    }
}

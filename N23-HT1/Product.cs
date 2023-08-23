using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT1
{
    public class Product
    {
        public string Name { get; set; }
        public int Stars { get; set; }
        public int Inventory { get; set; }

        public Product(string name, int stars, int inventory)
        {
            Name = name;
            Stars = stars;
            Inventory = inventory;
        }
    }

}

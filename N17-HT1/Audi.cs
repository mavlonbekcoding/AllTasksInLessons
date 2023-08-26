using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1
{
    public sealed class Audi : CarRental
    {
        public override string ModelName => "Audi";
        public override double RentPricePerHour => 20;

        public Audi(int id) : base("Audi", id) { }
    }
}

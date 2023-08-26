using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1
{
    public sealed class Bmw : CarRental
    {
        public override string ModelName => "BMW";
        public override double RentPricePerHour => 30;

        public Bmw(int id) : base("BMW", id) { }
    }
}

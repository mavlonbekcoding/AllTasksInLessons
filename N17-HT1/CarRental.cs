using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1
{
    public abstract class CarRental
    {
        public bool IsRented { get; protected set; }
        public DateTime RentStartTime { get; protected set; }
        public double Balance { get; protected set; }
        public string BrandName { get; }
        public int Id { get; }

        public abstract string ModelName { get; }
        public abstract double RentPricePerHour { get; }

        public CarRental(string brandName, int id)
        {
            BrandName = brandName;
            Id = id;
        }

        public void Rent()
        {
            IsRented = true;
            RentStartTime = DateTime.Now;
        }

        public virtual void Return()
        {
            if (IsRented)
            {
                IsRented = false;
                TimeSpan rentalDuration = DateTime.Now - RentStartTime;
                double rentalPrice = rentalDuration.TotalHours * RentPricePerHour;
                Balance += rentalPrice;
            }
        }
    }
}

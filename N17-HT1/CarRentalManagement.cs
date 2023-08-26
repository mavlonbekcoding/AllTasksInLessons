using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1
{
    public class CarRentalManagement
    {
       private List<CarRental> Cars = new List<CarRental>();
        public CarRentalManagement()
        {
            Cars = new List<CarRental>();
        }

        public void Add(CarRental car)
        {
            Cars.Add(car);
        }

        public CarRental Rent(string brandName)
        {
            CarRental car = Cars.Find(c => c.BrandName == brandName && !c.IsRented);

            if (car != null)
            {
                car.Rent();
                return car;
            }
            else
            {
                Console.WriteLine("Uzr, hozirda ijaraga moshina yo'q");
                return null;
            }
        }

        public void Return(CarRental car)
        {
            car.Return();
        }

        public void CalculateBalance()
        {
            double totalBalance = 0;

            foreach (CarRental car in Cars)
            {
                totalBalance += car.Balance;
            }

            Console.WriteLine($"Umumiy balance: ${totalBalance}");
        }
    }
}

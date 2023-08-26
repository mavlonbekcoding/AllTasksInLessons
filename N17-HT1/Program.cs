using N17_HT1;

public class Program
{
    static async Task Main(string[] args)
    {
        CarRentalManagement rentalManagement = new CarRentalManagement();

        Bmw bmw1 = new Bmw(1);
        Bmw bmw2 = new Bmw(2);
        Audi audi1 = new Audi(3);
        Audi audi2 = new Audi(4);

        rentalManagement.Add(bmw1);
        rentalManagement.Add(bmw2);
        rentalManagement.Add(audi1);
        rentalManagement.Add(audi2);

        async Task PerformRentalAndReturn(CarRental car, int seconds)
        {
            CarRental rentedCar = rentalManagement.Rent(car.BrandName);
            if (rentedCar != null)
            {
                await Task.Delay(1000 * seconds);
                rentalManagement.Return(rentedCar);
            }
        }

        await PerformRentalAndReturn(bmw1, 5);
        await PerformRentalAndReturn(bmw1, 6);
        await PerformRentalAndReturn(audi1, 4);
        await PerformRentalAndReturn(bmw1, 3);

        rentalManagement.CalculateBalance();
    }
}
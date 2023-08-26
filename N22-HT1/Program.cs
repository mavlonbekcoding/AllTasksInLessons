using System;
using System.Collections.Generic;
using System.Linq;

namespace N22_HT1
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 7, 2, 15, 3, 11, 8, 5 };

            var primeNumbers = numbers.Where(IsPrime).OrderByDescending(num => num).ToList();

            Console.WriteLine("Tub sonlar kamayish tartibida: ");
            foreach (var prime in primeNumbers)
            {
                Console.Write(prime + " ");
            }
        }
    }
}

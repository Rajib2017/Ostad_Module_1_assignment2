using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        public int Mileage;
        public void Drive(int kilometers)
        {
            Mileage += kilometers;
            Console.WriteLine("Car "+Brand+" "+Model+" has driven " + kilometers+" km.");
            Console.WriteLine("Total mileage:"+Mileage+" km.");
        }
        public void CarInfo()
        {
            Console.WriteLine("Car Info:");
            Console.WriteLine("Brand- " + Brand);
            Console.WriteLine("Model- " + Model);
            Console.WriteLine("Year- " + Year);
            Console.WriteLine("Mileage- " + Mileage + " km");
        }
    }
}

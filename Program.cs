namespace LearningCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Toyota = new Car();
            Car Tesla = new Car();

            Toyota.Brand = "Toyota";
            Toyota.Model = "Corolla";
            Toyota.Year = 2020;
            Toyota.Mileage = 15000;
            Toyota.Drive(100);
            Toyota.CarInfo();

            Tesla.Brand = "Tesla";
            Tesla.Model = "Model S";
            Tesla.Year = 2021;
            Tesla.Mileage = 5000;
            Tesla.Drive(200);
            Tesla.CarInfo();
        }



    }
}
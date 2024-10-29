using System.Text.Json;
using DomainModels;
namespace Bilbasen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvCar[] evCars = new EvCar[100];

            for (int i = 0; i < evCars.Length; i++)
            {
                evCars[i] = new EvCar();
            }

            //Vehicle[] vehicles = GetJsonData();

            string? firstCarBrand = evCars[0].GetBrand();
            int firstCarBrandCounter = 0;
            foreach (EvCar car in evCars)
            {
                firstCarBrandCounter = car.PrintSpecificVehicle(firstCarBrand, firstCarBrandCounter);
            }
            
            Console.WriteLine($"Total same cars of {firstCarBrand}: {firstCarBrandCounter}");
            
            string jsonString = JsonSerializer.Serialize(evCars, options: new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("data.json", jsonString);
        }
    }
    
}

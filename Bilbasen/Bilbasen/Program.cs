using System.Text.Json;
using DomainModels;
namespace Bilbasen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[100];

            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i] = new Vehicle();
            }

            //Vehicle[] vehicles = GetJsonData();

            string firstCarBrand = vehicles[0].GetBrand();
            int firstCarBrandCounter = 0;
            foreach (Vehicle car in vehicles)
            {
                firstCarBrandCounter = car.PrintSpecificVehicle(firstCarBrand, firstCarBrandCounter);
            }
            
            Console.WriteLine($"Total same cars of {firstCarBrand}: {firstCarBrandCounter}");
            
            string jsonString = JsonSerializer.Serialize(vehicles, options: new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("data.json", jsonString);
        }
        
        public static Vehicle[] GetJsonData()
        {
            return JsonSerializer.Deserialize<Vehicle[]>(File.ReadAllText("data.json"));
        }
    }
    
}

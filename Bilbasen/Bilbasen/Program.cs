using System.Text.Json;
using DomainModels;
namespace Bilbasen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] cars = new Vehicle[200];

            for (int i = 0; i < 100; i++)
            {
                cars[i] = new EvCar();
            }
            
            for (int i = 100; i < 200; i++)
            {
                cars[i] = new FossilCar();
            }
            
            foreach (var car in cars)
            {
                car.PrintVehicle();
            }
            
            /*string jsonString = JsonSerializer.Serialize(evCars, options: new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("data.json", jsonString);*/
        }
    }
    
}

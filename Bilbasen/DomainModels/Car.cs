namespace DomainModels
{
    public class Vehicle
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private int MileageKM { get; set; }
        private string Color { get; set; }
        private string FuelType { get; set; }
        private int WeightKG { get; set; }
        private string CarClass { get; set; }
        private int HorsePower { get; set; }
        
        private Random random = new Random();
        private static readonly string[] Brands = { "Toyota", "Honda", "Ford", "Chevrolet", "BMW" };
        private static readonly string[] Models = { "Camry", "Accord", "Mustang", "Cruz", "X5" };
        private static readonly string[] Colors = { "Red", "Blue", "Green", "Black", "White" };
        private static readonly string[] FuelTypes = { "Petrol", "Diesel", "Electric", "Hybrid" };
        private static readonly string[] CarClasses = { "Economy", "Luxury", "Sports", "SUV", "Truck" };

        public Vehicle()
        {
            Brand = Brands[random.Next(Brands.Length)];
            Model = Models[random.Next(Models.Length)];
            Year = random.Next(1970, 2023);
            MileageKM = random.Next(0, 300000);
            Color = Colors[random.Next(Colors.Length)];
            FuelType = FuelTypes[random.Next(FuelTypes.Length)];
            WeightKG = random.Next(800, 3000);
            CarClass = CarClasses[random.Next(CarClasses.Length)];
            HorsePower = random.Next(50, 500);
        }

        public string GetBrand()
        {
            return Brand;
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"----------------------------------------\n" +
                              $"Brand: {Brand}\n" +
                              $"Model: {Model}\n" +
                              $"Year: {Year}\n" +
                              $"MileageKM: {MileageKM}\n" +
                              $"Color: {Color}\n" +
                              $"Fuel type: {FuelType}\n" +
                              $"Weight: {WeightKG}\n" +
                              $"Car class: {CarClass}\n" +
                              $"Horse Power: {HorsePower}\n" +
                              $"----------------------------------------");
        }

        public int PrintSpecificVehicle(string firstCarBrand, int firstCarBrandCounter)
        {
            if (Brand == firstCarBrand)
            {
                PrintVehicle();
                return ++firstCarBrandCounter;
            }
            
            if (HorsePower > 200)
            {
                PrintVehicle();
            }
            else if (Color == "Red")
            {
                PrintVehicle();
            }
            else if (Year > 1980 && Year < 1999)
            {
                PrintVehicle();
            }
            else
            {
                Console.WriteLine("Not a valid vehicle");
            }

            return firstCarBrandCounter;
        }
    }

    public class Car
    {
        
    }
}

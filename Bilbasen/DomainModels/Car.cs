namespace DomainModels
{
    public enum GearType
    {
        Manual,
        Automatic
    }
    
    public class EvCar : IVehicle
    {
        public double Price {get;set;}
        public string? Brand {get;set;}
        public string? Model {get;set;}
        private int Year { get; set; }
        private int MileageKM { get; set; }
        private string Color { get; set; }
        private int WeightKg { get; set; }
        private GearType Gear = GearType.Automatic;
        private int HorsePower { get; set; }

        public EvCar()
        {
            Random random = new();
            string[] Brands = { "Tesla", "Nissan", "Chevrolet", "BMW", "Audi" };
            string[] Models = { "Model S", "Leaf", "Bolt", "i3", "e-tron" };
            string[] Colors = { "Red", "Blue", "Green", "Black", "White" };
        
            SetBrand(Brands[random.Next(Brands.Length)]);
            SetModel(Models[random.Next(Models.Length)]);
            Year = random.Next(2015, 2023);
            MileageKM = random.Next(0, 150000);
            Color = Colors[random.Next(Colors.Length)];
            WeightKg = random.Next(1500, 3000);
            HorsePower = random.Next(100, 500);
            int predefinedPrice = random.Next(30000, 100000);
            SetPrice(predefinedPrice);
        }

        public void SetBrand(string brandName)
        {
            Brand = brandName;
        }

        public void SetModel(string modelName)
        {
            Model = modelName;
        }

        public void SetPrice(int price)
        {
            double stupidFuckingGreenTax = 0.9;
            Price = price*stupidFuckingGreenTax;
        }
        
        public string? GetBrand()
        {
            return Brand;
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"----------------------------------------\n" +
                              $"Brand: {Brand}\n" +
                              $"Year: {Year}\n" +
                              $"MileageKM: {MileageKM}\n" +
                              $"Color: {Color}\n" +
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
    
    public class FossilCar : IVehicle
    {
        public double Price {get;set;}
        public string? Brand {get;set;}
        public string? Model {get;set;}
        private int Year { get; set; }
        private int MileageKM { get; set; }
        private string Color { get; set; }
        private int WeightKg { get; set; }
        private GearType Gear { get; set; }
        private int HorsePower { get; set; }
        
        public FossilCar()
        {
            Random random = new();
            string[] Colors = { "Red", "Blue", "Green", "Black", "White" };
            string[] Models = { "Camry", "Accord", "Mustang", "Cruz", "X5" };
            string[] Brands = { "Toyota", "Honda", "Ford", "Chevrolet", "BMW" };
            
            SetBrand(Brands[random.Next(Brands.Length)]);
            SetModel(Models[random.Next(Models.Length)]);
            Year = random.Next(2000, 2023);
            MileageKM = random.Next(0, 300000);
            Color = Colors[random.Next(Colors.Length)];
            WeightKg = random.Next(800, 3000);
            HorsePower = random.Next(100, 500);
            Gear = (GearType)random.Next(2);
            SetPrice(random.Next(5000, 50000));
        }

        public void SetBrand(string brandName)
        {
            Brand = brandName;
        }

        public void SetModel(string modelName)
        {
            Model = modelName;
        }

        public void SetPrice(int price)
        {
            Price = price;
        }

        public string? GetBrand()
        {
            return Brand;
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"----------------------------------------\n" +
                              $"Brand: {Brand}" +
                              $"Year: {Year}\n" +
                              $"MileageKM: {MileageKM}\n" +
                              $"Color: {Color}\n" +
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

    public interface IVehicle
    {
        double Price { get; set; }
        string Brand { get; set; }
        string Model { get; set; }

        void SetPrice(int price);
        void SetBrand(string brandName);
        void SetModel(string modelName);
        void PrintVehicle();
        string? GetBrand();
    }
}

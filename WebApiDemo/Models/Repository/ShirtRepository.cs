namespace WebApiDemo.Models.Repository
{
    public static class ShirtRepository
    {
        private static List<ShirtModel> shirts = new List<ShirtModel>()
        {
            new ShirtModel{ShirtId = 1,Brand="My Brand", Colour = "Blue", Gender = "Men", Price = 30, Size=10},
            new ShirtModel{ShirtId = 2,Brand="My Brand", Colour = "Black", Gender = "Men", Price = 35, Size=12},
            new ShirtModel{ShirtId = 3,Brand="Your Brand", Colour = "Pink", Gender = "Men", Price = 28, Size=8},
            new ShirtModel{ShirtId = 4,Brand="Your Brand", Colour = "Yellow", Gender = "Men", Price = 30, Size=9},

        };
        public static List<ShirtModel> GetShirts() 
        {
            return shirts; 
        }
        public static bool ShirtsExists(int id)
        {
            return shirts.Any(x =>x.ShirtId == id);
        }

        public static ShirtModel? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }

        public static ShirtModel? GetShirtByProperties(string? brand, string? gender, string? colour, int? size)
        {
            return shirts.FirstOrDefault(x =>
            !string.IsNullOrWhiteSpace(brand) &&
            !string.IsNullOrWhiteSpace(x.Brand) &&
            x.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(gender) &&
            !string.IsNullOrWhiteSpace(x.Gender) &&
            x.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(colour) &&
            !string.IsNullOrWhiteSpace(x.Colour) &&
            x.Colour.Equals(colour, StringComparison.OrdinalIgnoreCase) &&
            size.HasValue &&
            x.Size.HasValue &&
            size.Value == x.Size.Value
            );
        }

        public static void AddShirt(ShirtModel shirt)
        {
            int maxId = shirts.Max(x => x.ShirtId);
            shirt.ShirtId = maxId + 1;
            shirts.Add(shirt);
        }
    }
}

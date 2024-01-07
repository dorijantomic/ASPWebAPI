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
        public static bool ShirtsExists(int id)
        {
            return shirts.Any(x =>x.ShirtId == id);
        }

        public static ShirtModel? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}

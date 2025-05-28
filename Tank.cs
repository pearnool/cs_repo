// Класс резервуар
namespace Name
{
    public class Tank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Volume { get; set; }
        public int MaxVolume { get; set; }
        public int UnitId { get; set; }

        public static Tank[] GetTanks()
        {
            return new Tank[]
            {
                new Tank { Id = 1, Name = "Резервуар 1", Description = "Первый резервуар", Volume = 500, MaxVolume = 1000, UnitId = 1 },
                new Tank { Id = 2, Name = "Резервуар 2", Description = "Второй резервуар", Volume = 300, MaxVolume = 800, UnitId = 2 },
                new Tank { Id = 3, Name = "Резервуар 3", Description = "Третий резервуар", Volume = 700, MaxVolume = 1500, UnitId = 1 }
            };
        }
        public static Tank FindTankByName(Tank[] tanks, string name)
        {
            Tank specific_tank = new Tank { };
            for (int i = 0; i < tanks.Length; i++)
            {
                if (tanks[i].Name == name)
                {
                    specific_tank.Description = tanks[i].Description;
                    specific_tank.Id = tanks[i].Id;
                    specific_tank.MaxVolume = tanks[i].MaxVolume;
                    specific_tank.Name = tanks[i].Name;
                    specific_tank.UnitId = tanks[i].UnitId;
                    specific_tank.Volume = tanks[i].Volume;
                    return specific_tank;
                }
            }

            return null;
        }
        public static int GetTotalVolume(Tank[] tanks)
        {
            int totalVolume = 0;
            for (int i = 0; i < tanks.Length; i++)
            {
                totalVolume += tanks[i].Volume;
            }
            return totalVolume;
        }
    }
}
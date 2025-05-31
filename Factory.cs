// Класс фабрики
namespace Name
{
    public class Factory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public static Factory[] GetFactories()
        {
            return new Factory[]
            {
                new Factory { Id = 1, Name = "Фабрика 1", Description = "Первая фабрика" },
                new Factory { Id = 2, Name = "Фабрика 2", Description = "Вторая фабрика" }
            };
        }

    }
}
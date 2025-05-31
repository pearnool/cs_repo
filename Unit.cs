// Класс цеха
namespace Name
{
    public class Unit
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public static Unit[] GetUnits()
        {
            return new Unit[]
            {
            new Unit { Id = 1, Name = "Цех 1", Description = "Первый цех" },
            new Unit { Id = 2, Name = "Цех 2", Description = "Второй цех" }
            };
        }
    }
}
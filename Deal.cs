namespace Name
{
    public class Deal
    {
        public int Sum { get; set; }
        public string? Id { get; set; }
        public DateTime Date { get; set; }
        public static Deal[]? GetNumberOfDeals(Deal[]? deals)
        {
            return deals
                .Where(s => s.Sum >= 100) // Filter for deals with at least 100 sum
                .OrderByDescending(s => s.Date).Take(5) // Sort by Sum in descending order
                .Take(5)
                .ToArray(); // Convert the result back to an array

        }
        public static void dealprinter(Deal[]? deals)
        {
            if (deals != null)
            {
                for (int i = 0; i < deals.Length; i++)
                {
                    System.Console.WriteLine("Sum: " + deals[i].Sum+ " Id: "+deals[i].Id+" Date: "+deals[i].Date);
                }
            }
        }
    
    }

}
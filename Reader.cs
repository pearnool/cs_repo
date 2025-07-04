using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Name;

namespace Name
{
    public static class Reader
    {
        public static Tank[]? LoadTanksFromJson(string filePath)
        {
            string jsonFilePath = "tanks.json";

            // Read JSON from file
            string jsonString = File.ReadAllText(jsonFilePath);

            // Deserialize JSON into an array of tank objects
            Tank[]? tanks = JsonSerializer.Deserialize<Tank[]>(jsonString);

            // Output the deserialized data
            if (tanks != null)
            {
                for (int i = 0; i < tanks.Length; i++)
                {
                    Console.WriteLine($"Id: {tanks[i].Id}, Name: {tanks[i].Name}, Description: {tanks[i].Description}, Volume:{tanks[i].Volume}, MaxVolume: {tanks[i].MaxVolume}, UnitId: {tanks[i].UnitId} ");
                }
            }

            return tanks;
        }
        public static Deal[]? LoadDealsFromJson(string filePath)
        {
            string jsonFilePath = "JSON_sample_1.json";

            // Read JSON from file
            string jsonString = File.ReadAllText(jsonFilePath);

            // Deserialize JSON into an array of tank objects
            Deal[]? deals = JsonSerializer.Deserialize<Deal[]>(jsonString);

            // Output the deserialized data
            /*foreach (var deal in deals)
            {
                Console.WriteLine($"Sum: {deal.Sum}, Id: {deal.Id}, Date: {deal.Date} ");
            }*/
            if (deals != null)
            {
                for (int i = 0; i < deals.Length; i++)
                    {
                        Console.WriteLine($"Sum: {deals[i].Sum}, Id: {deals[i].Id}, Date: {deals[i].Date} ");
                    }
            }

            return deals;
        }
    }
}
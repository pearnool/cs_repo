using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Name;
public static class Reader
{
    public static Tank[]? LoadTanksFromJson(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            string json = reader.ReadToEnd();
            return JsonSerializer.Deserialize<Tank[]>(json);
        }
    }
}
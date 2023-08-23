using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        List<string> usernames = new List<string>
        {
            "Mavlonbek",
            "Asilbek",
            "Ma'murjon",
        };

        List<Task> tasks = new List<Task>();
        foreach (string username in usernames)
        {
            tasks.Add(CreateFileAsync(username));
        }

        await Task.WhenAll(tasks);

        Console.WriteLine("Hamma fayllar yaratildi");
    }

    static async Task CreateFileAsync(string username)
    {
        string fileName = $"{username}_file.txt";

        using (StreamWriter writer = File.CreateText(fileName))
        {
            await writer.WriteLineAsync($"Fayl {username} uchun yaratildi.");
        }

        Console.WriteLine($"Fayl {fileName} yaratildi");
    }
}

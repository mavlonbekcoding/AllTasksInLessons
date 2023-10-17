using N55_HT1;

public class Program
{
    static void Main()
    {

        FileService fileService = new FileService();
        Console.WriteLine($"Directory'lar soni : {fileService.GetDirectoryCount()}\n" +
                          $"Umimiy xajm : {fileService.GetTotalSize()}\n" +
                          $"File'larning soni : {fileService.GetFileCount()}\n" +
                          $"Eng katta hajmli file{fileService.GetLargestFile()}");
    }
}


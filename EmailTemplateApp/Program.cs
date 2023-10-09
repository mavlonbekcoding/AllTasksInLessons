using System.Text;

var mutex = new Mutex(false, "EmailFileMutex");

await Task.Run(() =>
{
    mutex.WaitOne();

    var fileStream = File.Open("interview.txt", FileMode.Open, FileAccess.ReadWrite);
    Console.WriteLine($"Template writer opened the file");

    var template = "Hello {{UserName}}, welcome to our platform";
    var buffer = Encoding.UTF8.GetBytes(template);

    fileStream.Write(buffer);
    fileStream.Flush();
    fileStream.Close();


    Console.WriteLine($"Template writer close the file");

    mutex.ReleaseMutex();
});
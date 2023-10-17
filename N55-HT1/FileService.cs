namespace N55_HT1;

public class FileService : IFileService
{
    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
    
    public int GetDirectoryCount()
    {
        int directoryCount = Directory.GetDirectories(projectDirectory).Length;
        return directoryCount;
    }

    public int GetFileCount()
    {
        int fileCount = Directory.GetFiles(projectDirectory).Length;
        return fileCount;
    }


    public string GetLargestFile()
    {
        var files = Directory.GetFiles(projectDirectory, ".", SearchOption.AllDirectories);
        string largestFile = files.OrderByDescending(x => new FileInfo(x).Length).First();
        return largestFile;
    }

    public long GetTotalSize()
    {
        var files = Directory.GetFiles(projectDirectory, ".", SearchOption.AllDirectories);
        long totalSize = files.Sum(x => new FileInfo(x).Length);
        return totalSize;
    }
}
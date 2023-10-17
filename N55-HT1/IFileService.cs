namespace N55_HT1;

public interface IFileService
{
    public int GetDirectoryCount();
    public int GetFileCount();
    public long GetTotalSize();
    public string GetLargestFile();
}

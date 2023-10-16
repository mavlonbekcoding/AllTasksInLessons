//string FilePath = @"D:\NT Level2";
//string fileName = "Program.cs";
// string GetFilePath(string FilePath, string fileName)
//{
//    string fullPath = FilePath + "\\" + fileName;

//    return fullPath;
//}
MyLogic logic = new MyLogic();

public class MyLogic
{
    string GetFilePath(string parentPath, string fileName)
    {
        string FullPath = $"{parentPath}+";
        return FullPath;
    }
}
string baseFolder = @"D:\\Test\";

for (int i = 1; i <= 3; i++)
{
    string subFolderName = $"test{i}";

    // Asosiy papkani yaratamiz
    DirectoryInfo mainFolder = new DirectoryInfo(Path.Combine(baseFolder, subFolderName));
    mainFolder.Create();

    // Har bir asosiy papka ichiga 5 marta folder yaratamiz
    for (int j = 1; j <= 3; j++)
    {
        string subFolderName = $"test{j}";
        DirectoryInfo subFolder = new DirectoryInfo(Path.Combine(mainFolder.FullName, subFolderName));
        subFolder.Create();
    }
}

using System.IO;

string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

string newDirectory = Path.Combine(projectDirectory, "Storage");

if (!Directory.Exists(newDirectory))
{
    Directory.CreateDirectory(newDirectory);
    projectDirectory = newDirectory;
}
string secondNewDirecoty = Path.Combine(projectDirectory, "User");

if (!Directory.Exists(secondNewDirecoty))
    Directory.CreateDirectory(secondNewDirecoty);

public 
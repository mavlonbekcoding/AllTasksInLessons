using SearchFileAndPath.Models;
using SearchFileAndPath.Service.Interfaces;
using System.Collections.Generic;

namespace SearchFileAndPath.Service.Services
{


        public IEnumerable<DirectoryStorage> SearchFiles(string parentPath, string fileName)
        {
            var directory = new DirectoryInfo(parentPath);

            var subDirectories = directory.GetDirectories();
            var subFiles = directory.GetFiles();
            foreach (var file in subFiles)
            {
                if (file.Name.Contains(fileName))
                {
                    yield return file.FullName;
                }
            }
            foreach (var subDirectory in subDirectories)
            {
                if (subDirectory.FullName.Contains("MSSQL16.SQLEXPRESS"))
                    continue;

                GetFilePath(subDirectory.FullName, fileName);
            }
        return Files;
        }
    }
}

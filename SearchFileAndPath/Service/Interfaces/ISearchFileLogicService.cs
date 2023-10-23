using SearchFileAndPath.Models;

namespace SearchFileAndPath.Service.Interfaces
{
    public interface ISearchFileLogicService
    {
        public IEnumerable<DirectoryStorage> SearchFiles(string parentPath,string fileName);
    }
}

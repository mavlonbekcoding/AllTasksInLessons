using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Abstractions.Models.FileSet;
using N48_HT1.Model;

namespace N48_HT1.DataAccess
{
    public interface IDataContext
    {
        IFileSet<User, Guid> Users { get; }

        ValueTask SaveChangesAsync();
    }
}

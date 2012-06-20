using System.Data.Entity;

namespace EFinContext
{
    public interface IHasDbContext<T>
        where T : DbContext
    {
        T Context { get; set; }
    }
}

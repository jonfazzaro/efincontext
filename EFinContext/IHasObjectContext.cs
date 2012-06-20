using System.Data.Objects;

namespace EFinContext
{
    public interface IHasObjectContext<T> 
        where T : ObjectContext
    {
        T Context { get; set; }
    }
}

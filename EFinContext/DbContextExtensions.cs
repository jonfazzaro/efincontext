using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;

namespace EFinContext
{
    public static class DbContextExtensions
    {
        public static void SetContextOnMaterialization<T>(this DbContext context)
            where T : DbContext
        {
            (context as IObjectContextAdapter).ObjectContext.ObjectMaterialized +=
                delegate(object sender, ObjectMaterializedEventArgs e)
                {
                    if (e.Entity is IHasDbContext<T>)
                        (e.Entity as IHasDbContext<T>).Context = context as T;
                };
        }
    }
}

using System.Data.Objects;

namespace EFinContext
{
    public static class ObjectContextExtensions
    {
        public static void SetContextOnMaterialization<T>(this ObjectContext context)
            where T : ObjectContext
        {
            context.ObjectMaterialized += 
                delegate(object sender, ObjectMaterializedEventArgs e) {
                    if (e.Entity is IHasObjectContext<T>)
                        (e.Entity as IHasObjectContext<T>).Context = context as T;
                };
        }

    }
}

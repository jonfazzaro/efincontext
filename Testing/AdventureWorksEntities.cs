namespace EFinContext.Testing
{
    partial class AdventureWorksEntities
    {
        partial void OnContextCreated()
        {
            this.SetContextOnMaterialization<AdventureWorksEntities>();
        }
    }
}

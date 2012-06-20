using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFinContext.Testing
{
    [TestClass]
    public class When_an_entity_is_materialized
    {
        [TestMethod]
        public void its_context_should_be_populated()
        {
            using (var db = new AdventureWorksEntities())
            {
                var firstContact = db.Contacts.First();
                Assert.IsNotNull(firstContact.Context, "Context was null.");
            }
        }

        [TestMethod]
        public void non_context_entities_should_work_too()
        {
            using (var db = new AdventureWorksEntities())
            {
                var firstType = db.ContactTypes.First();
                Assert.IsNotNull(firstType, "ContactType was null.");
            }
        }
    }
}

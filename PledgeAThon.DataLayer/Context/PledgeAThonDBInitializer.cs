using System.Data.Entity;
using PledgeAThon.Models.Domain;

namespace PledgeAThon.DataLayer.Context
{
    public class PledgeAThonDBInitializer : DropCreateDatabaseIfModelChanges<PaTContext>
    {
        protected override void Seed(PaTContext dbContext)
        {
            // seed data

            base.Seed(dbContext);
        }
    }
}

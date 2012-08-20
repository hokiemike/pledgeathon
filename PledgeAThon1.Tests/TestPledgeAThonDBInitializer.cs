using System.Data.Entity;
using PledgeAThon.DataLayer.Context;
using PledgeAThon.Models.Domain;

namespace PledgeAThon1.Tests
{
    public class TestPledgeAThonDBInitializer : DropCreateDatabaseIfModelChanges<PaTContext>
    {
        protected override void Seed(PaTContext dbContext)
        {
            // seed data
            var grp = new ParticipantGroup { Name = "3rd Grade - TEST GROUP", Description = "A TEST GROUP - DELETE ME" };
            dbContext.Groups.Add(grp);
            dbContext.SaveChanges();

            base.Seed(dbContext);
        }
    }
}

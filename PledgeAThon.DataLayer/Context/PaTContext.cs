using System.Data.Entity;
using PledgeAThon.Models.Domain;

namespace PledgeAThon.DataLayer.Context
{
    
    public class PaTContext : DbContext
    {
        public DbSet<ParticipantGroup> Groups { get; set; }
    }

    
}

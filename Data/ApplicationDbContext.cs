using ChallengeTask_v2.Tables;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTask_v2.Data
{
    public class ApplicationDbContext: DbContext
    {
        //public ApplicationDbContext()
        //{
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        DbSet<Collateral_agreements> collateral_Agreements { get; set; }
        DbSet<Contract_Frequencies> contract_s { get; set; }
        DbSet<Interest_frequency> frequencies { get; set; }
    }
}

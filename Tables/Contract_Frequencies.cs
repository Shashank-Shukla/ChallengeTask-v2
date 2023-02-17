using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTask_v2.Tables
{
    public class Contract_Frequencies
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int ContractFrequenciesID { get; set; }
        //public virtual Collateral_agreements CAs { get; set; }

        //public int? Collateral_Agreements_ID { get; set; }
        //[ForeignKey("Collateral_Agreements_ID")]
        ////public List<Collateral_agreements> IntFreq { get; set; }
        //public virtual Collateral_agreements Collateral_Agreements { get; set; }
        public string CFName { get; set; }

        public Collateral_agreements Collateral_Agreements_ID { get; set; }

        public List<Interest_frequency> IF_ID { get; set; } = new List<Interest_frequency>();
    }
}

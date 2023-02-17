using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTask_v2.Tables
{
    public class Collateral_agreements
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int CollateralAgreementID { get; set; }
        //[ForeignKey("CollateralAgreementID")]
        //public List<Contract_Frequencies> Cfs { get; set; }
        public string CAName { get; set; }

        public List<Contract_Frequencies> CF_ID { get; set; } = new List<Contract_Frequencies>();
    }
}

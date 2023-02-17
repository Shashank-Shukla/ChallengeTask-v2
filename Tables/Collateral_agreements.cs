using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTask_v2.Tables
{
    [Table("Collateral_Agreements")]
    public class Collateral_agreements
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int CollateralAgreementID { get; set; }
        public string CAName { get; set; }

        public List<Contract_Frequencies> CF_ID { get; set; } = new List<Contract_Frequencies>();
    }
}

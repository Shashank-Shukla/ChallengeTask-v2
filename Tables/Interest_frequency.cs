using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTask_v2.Tables
{
    [Table("Interest_Frequency")]
    public class Interest_frequency
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int InterestFrequencyID { get; set; }
        public string IFName { get; set; }

        public Contract_Frequencies Contract_Frequencies_ID { get; set; }
    }
}

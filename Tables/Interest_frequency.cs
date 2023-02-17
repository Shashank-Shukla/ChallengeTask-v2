using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTask_v2.Tables
{
    public class Interest_frequency
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int InterestFrequencyID { get; set; }
        //public virtual Contract_Frequencies Frequencies { get; set; }

        //public int? Contract_Frequencies_ID { get; set; }
        //[ForeignKey("Contract_Frequencies_ID")]
        ////public List<Contract_Frequencies> Frequency_ID { get; set; }
        //public virtual Contract_Frequencies Contract_Frequencies { get; set; }
        public string IFName { get; set; }

        public Contract_Frequencies Contract_Frequencies_ID { get; set; }
    }
}

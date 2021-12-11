using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FantasyFootballLibrary
{
    public class Contracts
    {
        [Key]
        public int ContractsId { get; set; }
        public int FiveYear { get; set; }
        public int FourYear { get; set; }
        public int ThreeYear { get; set; }
        public int TwoYear { get; set; }
        public int OneYear { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FantasyFootballLibrary
{
    public class Team
    {
        [Key]
        public int TeamId { get; set;}
        public int TeamName { get; set;}
        [ForeignKey("Owner")]
        public int OwnerId { get; set;}
        public Owner Owner { get; set;}
        [ForeignKey("Contract")]
        public int ContractId { get; set;}
        public Contracts Contracts { get; set;}
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public Contracts Player { get; set; }
    }
}

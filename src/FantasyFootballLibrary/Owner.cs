using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FantasyFootballLibrary
{
   public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        //used for EF
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }


    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FantasyFootballLibrary
{
    public class Team
    {
        [Key]
        public int TeamId { get; set;}
        public string TeamName { get; set;}
        public int FourYearContracts { get; set; }
        public int ThreeYearContracts { get; set; }
        public int TwoYearContracts { get; set; }
        public int OneYearContracts { get; set; }
        //foreign key to aspnetuser table?
    }
}

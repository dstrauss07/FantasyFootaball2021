using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FantasyFootballLibrary
{
    public class ExtensionApplied
    {
        [Key]
        public int ExtensionAppliedId { get; set; }
        public int YearApplied { get; set;}
        public bool Franchise { get; set; }
        public bool Extend { get; set; }
        [ForeignKey("Player")]
        public int PlayerId { get; set;}
        public Player Player { get; set;}
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}

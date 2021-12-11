using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballLibrary
{
    public class Player
    {
        public int PlayerId { get; set;}
        public int ContractYears { get; set;}
        public int PlayerFirstName { get; set;}
        public int PlayerLastName { get; set;}
        public int PlayerAge { get; set;}
        public int PlayerPosition { get; set;}
        public int SleeperPlayerId { get; set;}
        [ForeignKey("Team")]
        public int TeamId { get; set;}
        public Team Team { get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FantasyFootballLibrary
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set;}
        public int ContractYears { get; set;}
        public string PlayerFirstName { get; set;}
        public string PlayerLastName { get; set;}
        public int PlayerAge { get; set;}
        public string PlayerPosition { get; set;}
        public string NflTeam { get; set; }
        public int SleeperPlayerId { get; set;}
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
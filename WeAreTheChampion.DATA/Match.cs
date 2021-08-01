﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampion.DATA
{
   public class Match
    {
        public int Id { get; set; }
        public DateTime MatchTime { get; set; }
        [Required]
        public int Team1Id { get; set; }
        [Required]
        public int Team2Id { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Result { get; set; }


    }
}

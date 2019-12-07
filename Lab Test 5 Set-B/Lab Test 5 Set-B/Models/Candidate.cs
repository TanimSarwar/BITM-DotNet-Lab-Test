using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Test_5_Set_B.Models
{
    public class Candidate
    {
        public  int Id { get; set; }
        [Required]
        public string Candidatename { get; set; }
        [Required]
        public string CandidateSymbol { get; set; }
    }
}
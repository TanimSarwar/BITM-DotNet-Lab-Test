using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Test_5_Set_B.Models
{
    public class Voter
    {
        public int Id { get; set; }
        [Required]
        public string VotersName { get; set; }
        [Required]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "Voter Id Must Be a 17 Digit Long Number")]
        public string VotersId { get; set; }

    }
}
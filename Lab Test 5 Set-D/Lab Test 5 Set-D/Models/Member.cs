using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Test_5_Set_D.Models
{
    public class Member
    {
        public int Id { get; set; } 
        [Required]
        public int Number { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
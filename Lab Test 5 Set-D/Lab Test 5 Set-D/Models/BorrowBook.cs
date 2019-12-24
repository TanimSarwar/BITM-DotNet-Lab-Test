using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Test_5_Set_D.Models
{
    public class BorrowBook
    {
        public int Id { get; set; } 
        [Required]
        public int MemberId { get; set; }

        [Required]
        public int BookTitle { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }

        public string BookName { get; set; }
    }
}
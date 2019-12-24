using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Test_5_Set_C.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        [Required]
        public string RegNo { get; set; }
        [Required]
        public string EngineNo { get; set; }
    }
}
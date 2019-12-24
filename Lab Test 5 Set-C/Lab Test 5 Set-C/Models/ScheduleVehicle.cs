using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Lab_Test_5_Set_C.Models
{
    public class ScheduleVehicle
    {
        public int Id { get; set; }
        [Required]
        public int VehicleId { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]

        public string Shift { get; set; }
        [Required]

        public string Customer { get; set; }
        [Required]

        public string Address { get; set; }

    }
}
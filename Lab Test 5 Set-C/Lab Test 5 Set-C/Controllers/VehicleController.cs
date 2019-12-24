using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_Test_5_Set_C.Manager;
using Lab_Test_5_Set_C.Models;

namespace Lab_Test_5_Set_C.Controllers
{
    public class VehicleController : Controller
    {
        VehicleManager aVehicleManager = new VehicleManager();
        [HttpGet]
        public ActionResult StartPage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SaveVehicle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveVehicle(Vehicles aVehicle)
        {
            ViewBag.Message = aVehicleManager.SaveVehicle(aVehicle);
            return View();
        }
        [HttpGet]
        public ActionResult ScheduleVehicle()
        {
            ViewBag.Shifts = GetAllShifts();
            ViewBag.Vehicles = GetAllVehicles();
            return View();
        }
        [HttpPost]
        public ActionResult ScheduleVehicle(ScheduleVehicle aScheduleVehicle)
        {
            ViewBag.Shifts = GetAllShifts();
            ViewBag.Vehicles = GetAllVehicles();
            ViewBag.Message = aVehicleManager.ScheduleVehicle(aScheduleVehicle);
            return View();
        }

        private List<Shift> GetAllShifts()
        {
            List<Shift> shifts = new List<Shift>
            {
                new Shift {Id=1, Name = "Morning"},
                new Shift {Id=2, Name = "Evening"}
            };
            return shifts;

        }
        
        public ActionResult ViewSchedule(ScheduleVehicle aScheduleVehicle)
        {
            //ViewBag.Vehicles = GetAllVehicles();
            ViewBag.GetAllVehiclesRegNo = aVehicleManager.GetAllVehicles();
            ViewBag.bookedVehicleList = aVehicleManager.ViewSchedule(aScheduleVehicle);
            return View();
        }

        //[HttpPost]
        //public ActionResult ViewSchedule(ScheduleVehicle aScheduleVehicle)
        //{
        //    ViewBag.bookedVehicleList = aVehicleManager.ViewSchedule(aScheduleVehicle);
        //    //ViewBag.Vehicles = GetAllVehicles();
        //    ViewBag.GetAllVehiclesRegNo = aVehicleManager.GetAllVehicles();

        //    return View();
        //}
       
        public IEnumerable<SelectListItem> GetAllVehicles()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "---Select---",Value = ""},                
            };
            List<Vehicles> listOfVehicles = aVehicleManager.GetAllVehicles();
            foreach (Vehicles vehicles in listOfVehicles)
            {
                SelectListItem selectListItem = new SelectListItem();
                selectListItem.Text = vehicles.RegNo;
                selectListItem.Value = vehicles.Id.ToString();
                selectListItems.Add(selectListItem);
            }

            return selectListItems;
        }
	}
}
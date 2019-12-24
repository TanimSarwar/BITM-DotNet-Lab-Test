using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab_Test_5_Set_C.Gateway;
using Lab_Test_5_Set_C.Models;

namespace Lab_Test_5_Set_C.Manager
{
    public class VehicleManager
    {
        VehicleGateway aVehicleGateway = new VehicleGateway();
        public string SaveVehicle(Vehicles aVehicle)
        {
            if (aVehicleGateway.IsVehicleRegNoExist(aVehicle))
            {
                return "Reg No is Already Exist";
            }
            if (aVehicleGateway.IsVehicleEngineNoExist(aVehicle))
            {
                return "Engine No is already Exist";
            }
            else
            {
                int rowAffected = aVehicleGateway.SaveVehicle(aVehicle);
                if (rowAffected>0)
                {
                    return "Vehicle Info Saved Successfully";
                }
            }
            return "Vehicle info Not Saveed";
        }

        public List<Vehicles> GetAllVehicles()
        {
            return aVehicleGateway.GetAllVehicles();
        }

        public string ScheduleVehicle(ScheduleVehicle aScheduleVehicle)
        {
            if (aVehicleGateway.IsAlreadyBooked(aScheduleVehicle))
            {
                return "Vehicle is not available";
            }
            int rowAffected = aVehicleGateway.ScheduleVehicle(aScheduleVehicle);
            if (rowAffected>0)
            {
                return "Vehicle is Booked";
            }
            return "Vehicle is not Booked";
        }

        public List<ScheduleVehicle> ViewSchedule(ScheduleVehicle aScheduleVehicle)
        {
            return aVehicleGateway.ViewBookedVehicles(aScheduleVehicle);
        }
    }
}
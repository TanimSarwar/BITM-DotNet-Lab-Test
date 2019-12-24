using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Lab_Test_5_Set_C.Models;

namespace Lab_Test_5_Set_C.Gateway
{
    public class VehicleGateway : Gateway
    {
        public bool IsVehicleRegNoExist(Vehicles aVehicle)
        {
            Query = "SELECT * FROM VehiclesTable WHERE RegNo = @regNo";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("regNo", aVehicle.RegNo);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public bool IsVehicleEngineNoExist(Vehicles aVehicle)
        {
            Query = "SELECT * FROM VehiclesTable WHERE EngineNo = @engineNo";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("engineNo", aVehicle.EngineNo);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public int SaveVehicle(Vehicles aVehicle)
        {
            Query = "INSERT INTO VehiclesTable VALUES (@regNo, @engineNo)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("regNo", aVehicle.RegNo);
            Command.Parameters.AddWithValue("engineNo", aVehicle.EngineNo);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<Vehicles> GetAllVehicles()
        {
            Query = "SELECT * FROM VehiclesTable";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            List<Vehicles> vehicles = new List<Vehicles>();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Vehicles aVehicles = new Vehicles();
                aVehicles.Id = Convert.ToInt32(Reader["Id"].ToString());
                aVehicles.RegNo = Reader["RegNo"].ToString();
                vehicles.Add(aVehicles);
            }
            Reader.Close();
            Connection.Close();
            return vehicles;
        }

        public int ScheduleVehicle(ScheduleVehicle aScheduleVehicle)
        {
            Query = "INSERT INTO ScheduleTable VALUES (@vehicleId, @date, @shift, @customer, @address)";
            //Query = "INSERT INTO StudentTable Values('" + aScheduleVehicle.VehicleId + "','" + student.StudentEmail + "','" + student.StudentContactNo + "','" + student.StudentAddDate + "','" + student.StudentAddress + "','" + student.StudentRegNo + "'," + student.DepartmentId + ")";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("vehicleId", aScheduleVehicle.Id);
            Command.Parameters.AddWithValue("date", aScheduleVehicle.Date);
            Command.Parameters.AddWithValue("shift", aScheduleVehicle.Shift);
            Command.Parameters.AddWithValue("customer", aScheduleVehicle.Customer);
            Command.Parameters.AddWithValue("address", aScheduleVehicle.Address);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool IsAlreadyBooked(ScheduleVehicle aScheduleVehicle)
        {
            Query = "SELECT * FROM ScheduleTable WHERE VehicleID = @vehicleId AND Shift = @shift AND Date = @date";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("vehicleId", aScheduleVehicle.Id);
            Command.Parameters.AddWithValue("shift", aScheduleVehicle.Shift);
            Command.Parameters.AddWithValue("date", aScheduleVehicle.Date);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }
        public List<ScheduleVehicle> ViewBookedVehicles(ScheduleVehicle aScheduleVehicle)
        {
            Query = "SELECT * FROM ScheduleTable WHERE VehicleId = @vehicleId";
            Command= new SqlCommand(Query,Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("vehicleId", aScheduleVehicle.Id);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<ScheduleVehicle> bookedVehicles = new List<ScheduleVehicle>();
            

            while (Reader.Read())
            {
                ScheduleVehicle aScheduledVehicle = new ScheduleVehicle
                {
                    Date = Reader["Date"].ToString(),
                    Shift = Reader["Shift"].ToString()
                };
                bookedVehicles.Add(aScheduledVehicle);
            }
            Connection.Close();
            Reader.Close();
            return bookedVehicles;
        }
    }
}
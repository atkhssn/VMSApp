using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Infrastructure.Utility
{
    public class EnumCollection
    {
        public enum color
        {
            Red,
            White,
            Black,
            Yellow
        }

        public enum vehicleType
        {
            Hybrid = 0,
            Standard = 1
        }

        public enum vehicleMode
        {
            Own = 1,
            Rental = 2
        }

        public enum Condition
        {
            Completed = 2,
            Incompleted = 3
        }

        public enum OvertimeStatus
        {
            OnTime,
            OverTime
        } public enum VehicleCapacity
        {
            Ton,
            Person
        }

        public enum TollType 
        { 
        
        
        }
        public enum vehicleCategory 
        {
            Hatchback=1,
             SUV, 
            MUV,

             MicroCar,
            ElectricCar,
            PickupTruck,
            ContainerTruck,
            OpenTrailorTruc 

        }

        public enum DriverShift
        {
            DatShift = 1,
            NightShift
        }

    }
}

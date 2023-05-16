using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class SharedParkingModel
    {
        public int SharedParkingId { get; set; }
        public int? ParkId { get; set; }
        public ParkModel Park { get; set; }
        public DateTime SharedDate { get; set; }
        public int Day { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public bool IsOccupied { get; set; }
        public SharedParkingModel(int sharedParkingId, int? parkId, ParkModel park, DateTime sharedDate, int day, int startHour, int endHour, bool isOccupied)
        {
            SharedParkingId = sharedParkingId;
            ParkId = parkId;
            Park = park;
            SharedDate = sharedDate;
            Day = day;
            StartHour = startHour;
            EndHour = endHour;
            IsOccupied = isOccupied;
        }
        public SharedParkingModel()
        {

        }
    }
}

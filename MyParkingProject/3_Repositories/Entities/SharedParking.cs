using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Entities
{
    public class SharedParking
    {
        [Key]
        [Column(Order = 1)]
        public int SharedParkingId { get; set; }
        public int? ParkId { get; set; }
        public Park Park { get; set; }
        public DateTime SharedDate { get; set; }
        public int Day { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public bool IsOccupied { get; set; }

    }
}

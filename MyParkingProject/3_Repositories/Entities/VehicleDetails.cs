using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Entities
{
    public class VehicleDetails
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public VehicleType VType { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}

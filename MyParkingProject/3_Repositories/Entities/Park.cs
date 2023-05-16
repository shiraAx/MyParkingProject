using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Entities
{
    public class Park
    {
        [Key]
        [Column(Order = 1)]
        public int ParkId { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public string Adress { get; set; }
        public VehicleType AdaptationVType { get; set; }
    }
}

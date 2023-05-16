using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Entities
{
    public class Complaints
    {
        [Key]
        [Column(Order = 1)]
        public int ComplaintId { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public string ComplaintStr { get; set; }
        public int? VehicleId { get; set; }
        public VehicleDetails Vehicle { get; set; }
        public string src { get; set; }
        public int? RecentUsesId { get; set; }
        public RecentUses RecentUses { get; set; }


    }
}

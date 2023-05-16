using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Entities
{
    public class PurchasePoints
    {
        [Key]
        [Column(Order = 1)]
        public int PurchasePointId { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Entities
{
    public class User
    {
        [Key]
        [Column(Order = 1)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int Scores { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class RecentUsesModel
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public UserModel User { get; set; }
        public DateTime EnterDateTime { get; set; }
        public DateTime LeaveDateTime { get; set; }
        public RecentUsesModel(int id, int? userId, UserModel user, DateTime enterDateTime, DateTime leaveDateTime)
        {
            Id = id;
            UserId = userId;
            User = user;
            EnterDateTime = enterDateTime;
            LeaveDateTime = leaveDateTime;
        }
        public RecentUsesModel()
        {

        }
    }
}

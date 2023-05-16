using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class ComplaintsModel
    {
        public int ComplaintId { get; set; }
        public int? UserId { get; set; }
        public UserModel User { get; set; }
        public string ComplaintStr { get; set; }
        public int? VehicleId { get; set; }
        public VehicleDetailsModel Vehicle { get; set; }
        public string Src { get; set; }
        public int? RecentUsesId { get; set; }
        public RecentUsesModel RecentUses { get; set; }

        public ComplaintsModel(int complaintId, int? userId, UserModel user, string complaintStr, int? vehicleId, VehicleDetailsModel vehicle, string src, int? recentUsesId, RecentUsesModel recentUses)
        {
            ComplaintId = complaintId;
            UserId = userId;
            User = user;
            ComplaintStr = complaintStr;
            VehicleId = vehicleId;
            Vehicle = vehicle;
            Src = src;
            RecentUsesId = recentUsesId;
            RecentUses = recentUses;
        }
        public ComplaintsModel()
        {

        }
    }
}

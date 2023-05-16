using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class ParkModel
    {
        public int ParkId { get; set; }
        public int? UserId { get; set; }
        public UserModel User { get; set; }
        public string Adress { get; set; }
        public VehicleTypeModel AdaptationVType { get; set; }
        public ParkModel(int parkId, int? userId, UserModel user, string adress, VehicleTypeModel adaptationVType)
        {
            ParkId = parkId;
            UserId = userId;
            User = user;
            Adress = adress;
            AdaptationVType = adaptationVType;
        }
        public ParkModel()
        {

        }
    }
}

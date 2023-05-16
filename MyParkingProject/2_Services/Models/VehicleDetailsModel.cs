using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class VehicleDetailsModel
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public VehicleTypeModel VType { get; set; }
        public int? UserId { get; set; }
        public UserModel User { get; set; }
        public VehicleDetailsModel(int id, string licensePlate, VehicleTypeModel vType, int? userId, UserModel user)
        {
            Id = id;
            LicensePlate = licensePlate;
            VType = vType;
            UserId = userId;
            User = user;
        }
        public VehicleDetailsModel()
        {

        }
    }
}

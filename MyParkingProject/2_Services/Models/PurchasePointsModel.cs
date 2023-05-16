using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class PurchasePointsModel
    {
        public int PurchasePointId { get; set; }
        public int? UserId { get; set; }
        public UserModel User { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public PurchasePointsModel(int purchasePointId, int? userId, UserModel user, DateTime date, int score)
        {
            PurchasePointId = purchasePointId;
            UserId = userId;
            User = user;
            Date = date;
            Score = score;
        }
        public PurchasePointsModel()
        {

        }
    }
}

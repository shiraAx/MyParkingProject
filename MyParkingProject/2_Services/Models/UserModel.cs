using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int Scores { get; set; }
        public UserModel(int userId, string name, string passWord, string email, string adress, string phoneNumber, int scores)
        {
            UserId = userId;
            Name = name;
            PassWord = passWord;
            Email = email;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Scores = scores;
        }
        public UserModel()
        {

        }
    }
}

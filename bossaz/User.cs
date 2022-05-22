using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJob
{
    abstract class User
    {
        public User()
        {
            ID = UserID++;
        }
        public int ID { get; set; }
        public static int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nPhone Number: {PhoneNumber}\nEmail: {Email}\nUsername: {Username}\n";
        }
    }
}

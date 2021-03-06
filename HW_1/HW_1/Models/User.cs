using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW_1.Models.DAL;

namespace HW_1.Models
{
    public class User
    {
        string name;
        string lastName;
        string email;
        string password;
        string cellphone;
        string gender;
        int yearBirth;
        string genre;
        string address;

        

        public User()
        {

        }
        public User(string name, string lastName, string email, string password, string cellphone, string gender, int yearBirth, string genre, string address)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Cellphone = cellphone;
            this.Gender = gender;
            this.YearBirth = yearBirth;
            this.Genre = genre;
            this.Address = address;
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public string Gender { get => gender; set => gender = value; }
        public int YearBirth { get => yearBirth; set => yearBirth = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Address { get => address; set => address = value; }



        public int InsertUser()
        {
            Console.WriteLine("InsertUser - user.cs step 2");

            DataServices ds = new DataServices();
            ds.InsertUserDS(this);
            return 1;
        }

    }
}
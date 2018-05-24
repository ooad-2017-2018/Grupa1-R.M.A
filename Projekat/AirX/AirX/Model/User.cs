using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class User
    {
        private string id;
        private string userType;
        private string givenName;
        private string surname;
        private bool gender;
        private DateTime birthDate;
        private string birthPlace;
        private string nationality;

        private string physicalAdress;
        private string phoneNumber;

        private string userName;
        private string emailAdress;
        private string password;

        public User(string givenName, string surname, bool gender, DateTime birthDate, string birthPlace, string nationality, string physicalAdress, string phoneNumber, string userName, string email, string password)
        {
            GivenName = givenName;
            Surname = surname;
            Gender = gender;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
            Nationality = nationality;
            PhysicalAdress = physicalAdress;
            PhoneNumber = phoneNumber;
            UserName = userName;
            Email = email;
            Password = password;
            Id = userName;
        }

        public string GivenName { get => givenName; set => givenName = value; }
        public string Surname { get => surname; set => surname = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string BirthPlace { get => birthPlace; set => birthPlace = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string PhysicalAdress { get => physicalAdress; set => physicalAdress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => emailAdress; set => emailAdress = value; }
        public string Password { get => password; set => password = value; }
        public string UserType { get => userType; set => userType = value; }
        public string Id { get => id; set => id = value; }

        public string Name { get => givenName +" "+ surname; }
    }
}

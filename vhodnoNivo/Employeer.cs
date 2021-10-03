using System;
using System.Collections.Generic;
using System.Text;

namespace vhodnoNivo
{
    public class Employeer
    {
        private string firstName;
        private string middleName;
        private string familyName;
        private readonly Living address;
        private string phoneNumber;
        private double salary;

        public Employeer(string first, string middle, string last, string city, string phone, double salary) {
            this.firstName = first;
            this.middleName = middle;
            this.familyName = last;
            this.phoneNumber = phone;
            this.salary = salary;
            this.address = new Living(city);
        }
           
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string FamilyName
        {
            get { return this.familyName; }
            set { this.familyName = value; }
        }

        public string AddressCity
        {
            get { return this.address.City; }
            set { this.address.City = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
    }
    

}

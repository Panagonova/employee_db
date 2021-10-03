using System;
using System.Collections.Generic;
using System.Text;

namespace vhodnoNivo
{
    class DB
    {
        private List<Employeer> employee = new List<Employeer>();
        private bool hasChange = false;
        public void Add(Employeer employeer)
        {
            this.employee.Add(employeer);
            this.hasChange = true;
        }

        public void Remove(string firstName, string familyName)
        {

            foreach(Employeer employeer in this.employee)
            {
                if(employeer.FirstName.ToLower() == firstName && employeer.FamilyName.ToLower() == familyName)
                {
                    this.employee.Remove(employeer);
                    this.hasChange = true;
                    Console.WriteLine($"Employeer {firstName} {familyName} was removed successfully");
                    return;
                }
            }

            Console.WriteLine($"Employeer {firstName} {familyName} was not found!");
        }

        public List<string> ReadDataToText(string delimiter)
        {
            List<string> lines = new List<string>();
            foreach( Employeer employer in this.employee)
            {
                List<string> line = new List<string>();
                line.Add(employer.FirstName);
                line.Add(employer.MiddleName);
                line.Add(employer.FamilyName);
                line.Add(employer.AddressCity);
                line.Add(employer.PhoneNumber);
                line.Add(employer.Salary.ToString());
                lines.Add(String.Join(delimiter, line));
            }
            return lines;
        }

        public List<Employeer> Sort(string field, string direction)
        {

            List<Employeer> sortedList = this.employee;

           
            sortedList.Sort(delegate (Employeer a, Employeer b)
            {

                if (field == "firstName")
                {
                    return direction == "ascending" ? a.FirstName.CompareTo(b.FirstName) : b.FirstName.CompareTo(a.FirstName);
                }
                else if (field == "familyName")
                {
                    return direction == "ascending" ? a.FamilyName.CompareTo(b.FamilyName) : b.FamilyName.CompareTo(a.FamilyName);
                }
                else if (field == "address")
                {
                    return direction == "ascending" ? a.AddressCity.CompareTo(b.AddressCity) : b.AddressCity.CompareTo(a.AddressCity);
                }
                else
                {
                    return direction == "ascending" ? a.Salary.CompareTo(b.Salary) : b.Salary.CompareTo(a.Salary);
                }
            });


            return sortedList;
        }

        public bool HasChange
        {
            get { return this.hasChange; }
            set { this.hasChange = value; }
        }
    }
}

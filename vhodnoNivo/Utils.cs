using System;
using System.Collections.Generic;
using System.Text;

namespace vhodnoNivo
{
    public static class Utils
    {
        public static int MainMenu(string userType)
        {
            bool noError = true;
            int choice = 0;

            Console.WriteLine("");
            if (userType == "admin")
            {
                Console.WriteLine("1 - Add employee");
                Console.WriteLine("2 - Remove employee by first and family name");
            }

            Console.WriteLine("3 - Sorting by first name");
            Console.WriteLine("4 - Sorting by family name");
            Console.WriteLine("5 - Sorting by adrress city");
            Console.WriteLine("6 - Sorting by salary");
            Console.WriteLine("7 - Exit");


            do
            {
                noError = true;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if ((choice < 1 || choice > 7) && userType == "admin")
                    {
                        Console.WriteLine("Invalid Input value. Please try again.");
                        noError = false;
                    }
                    if ((choice < 3 || choice > 7) && userType == "user")
                    {
                        Console.WriteLine("Invalid Input value. Please try again.");
                        noError = false;
                    }
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine($"Invalid Input value. Please try again. {e}");
                    continue;
                }
            } while (noError == false);


            return choice;

        }
        public static void WriteEmployee(List<Employeer> employee, string userType)
        {
            Console.WriteLine("");
            int counter = 1;
            foreach (Employeer employeer in employee)
            {
                string salary = userType == "admin" ? employeer.Salary.ToString("F2") : "";
                Console.WriteLine($"{counter}. - {employeer.FirstName} {employeer.MiddleName} {employeer.FamilyName}; city: {employeer.AddressCity};  phone: {employeer.PhoneNumber}; salary: {salary}");
                counter++;
            }
        }

        public static Employeer NewEmployeer()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine().Trim();

            Console.WriteLine("Enter Middle Name:");
            string middleName = Console.ReadLine().Trim();

            Console.WriteLine("Enter Family Name:");
            string familyName = Console.ReadLine().Trim();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine().Trim();

            Console.WriteLine("Enter Phone number:");
            string phoneNumber = Console.ReadLine().Trim();

            Console.WriteLine("Enter Salary:");
            double salary = double.Parse(Console.ReadLine().Trim());

            Employeer employer = new Employeer(firstName, middleName, familyName, city, phoneNumber, salary);

            return employer;
        }
    }
}

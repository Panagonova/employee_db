using System;
using System.Collections.Generic;

namespace vhodnoNivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userType = "admin";
            string delimiter = "^";
            DB db = new DB();

            Files fileManager = new Files("C:/Users/tspan/source/repos/vhodnoNivo/vhodnoNivo/db_data");
            List<string> fileContent = fileManager.ReadToFile();

            foreach (string line in fileContent)
            {
                string[] splitLine = line.Split(delimiter);
                string firstName = splitLine[0];
                string middleName = splitLine[1];
                Employeer employeer = new Employeer(firstName, middleName, splitLine[2], splitLine[3], splitLine[4], double.Parse(splitLine[5]));
                db.Add(employeer);
            }

            while (true)
            {
                int choice = Utils.MainMenu(userType);

                if (choice == 1)
                {
                    Employeer employeer = Utils.NewEmployeer();
                    db.Add(employeer);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter First Name:");
                    string firstName = Console.ReadLine().Trim().ToLower();

                    Console.WriteLine("Enter Family Name:");
                    string familyName = Console.ReadLine().Trim().ToLower();

                    db.Remove(firstName, familyName);

                }
                else if(choice == 3)
                {
                    List<Employeer> employee = db.Sort("firstName", "ascending");
                    Utils.WriteEmployee(employee, userType);
                }
                else if (choice == 4)
                {
                    List<Employeer> employee = db.Sort("familyName", "ascending");
                    Utils.WriteEmployee(employee, userType);
                }
                else if (choice == 5)
                {
                    List<Employeer> employee = db.Sort("address", "ascending");
                    Utils.WriteEmployee(employee, userType);
                }
                else if (choice == 6)
                {
                    List<Employeer> employee = db.Sort("salary", "ascending");
                    Utils.WriteEmployee(employee, userType);
                }
                else if (choice == 7)
                {
                    if (db.HasChange)
                    {
                        List<string> employeesData = db.ReadDataToText(delimiter);
                        fileManager.WriteToFile(employeesData);
                    }
                    
                    break;
                }
                    
            }
        }
    }
}

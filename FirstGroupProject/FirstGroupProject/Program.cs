using FirstGroupProject.Employees;
using FirstGroupProject.BaseRepository;
using System;


namespace FirstGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int storeNumber;
            Console.WriteLine("Mmmm, yes. Lets talk money. You run this town. Lets look at the districts!\n\x1B[4m");

            Console.WriteLine("Please choose an option:\x1B[0m");
            Console.WriteLine("1- Enter Store Sales");
            Console.WriteLine("2- Generate District Report");
            Console.WriteLine("3- Add New Employee");
            Console.WriteLine("4- Add a Store/District");
            Console.WriteLine("5- Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("WE'RE STILL WORKING ON THIS");
                    break;
                case "2":
                    Console.WriteLine("WE'RE STILL WORKING ON THIS");
                    break;
                case "3":
                    Console.WriteLine("We're adding an employee");
                    Console.Write("What store number? ");
                    storeNumber = Int32.Parse(Console.ReadLine());
                    var associatedStores = new Employee();
                    associatedStores.ListEmployees(storeNumber);
                    break;
                case "4":
                    Console.WriteLine("WE'RE STILL WORKING ON THIS");
                    break;
                case "5":
                    Console.WriteLine("WE'RE STILL WORKING ON THIS");
                    break;
            }
        }
    }
}

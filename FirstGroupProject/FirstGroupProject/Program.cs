using FirstGroupProject.Employees;
using System;


namespace FirstGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: add dummy data if needed
            int storeNumber;
            string name;
            string jobTitle;
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
                    // do we generate 4 random values to add to a sales list/dictionary?
                    // do we keep it simple and manually input each value to append to existing collection?
                    break;
                case "2":
                    Console.WriteLine("WE'RE STILL WORKING ON THIS");
                    break;
                case "3":
                    Console.WriteLine("We're adding an employee");
                    Console.Write("What is their name?");
                    name = Console.ReadLine();
                    bool startLoop = true;
                    while (startLoop)
                    {
                        Console.WriteLine("\n\x1B[4m What is their job title?\x1B[0m ");
                        Console.WriteLine("1. District Manager");
                        Console.WriteLine("2. Store Manager");
                        Console.WriteLine("3. Assistant Manager");
                        Console.WriteLine("4. Associate");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                jobTitle = "District Manager";
                                Console.WriteLine(jobTitle);
                                startLoop = false;
                                break;
                            case "2":
                                jobTitle = "Store Manager";
                                Console.WriteLine(jobTitle);
                                startLoop = false;
                                break;
                            case "3":
                                jobTitle = "Assistant Manager";
                                Console.WriteLine(jobTitle);
                                startLoop = false;
                                break;
                            case "4":
                                jobTitle = "Associate";
                                Console.WriteLine(jobTitle);
                                startLoop = false;
                                break;
                            default:
                                Console.WriteLine("That is not a valid answer!");
                                break;

                        }
                    }
                    Console.Write("What store number? ");
                    storeNumber = Int32.Parse(Console.ReadLine());
                    //TODO: add new Employee to employee list
                    //TODO: display employee info report (maybe)
                    break;
                case "4":
                    Console.WriteLine("WE'RE STILL WORKING ON THIS");
                    //TODO: Create store variables and add them to collection
                    break;
                case "5":
                    Console.WriteLine("WE'RE STILL WORKING ON THIS");
                    break;
            }
        }
    }
}

using FirstGroupProject.Districts;
using FirstGroupProject.Employees;
using FirstGroupProject.Stores;
using FirstGroupProject.StoreSales;
using System;
using System.Collections.Generic;

namespace FirstGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: add dummy data if needed
            int storeNumber;
            Dictionary<int, Sale> wizardSalesDictionary = new();
            bool menuLoop = true;
            var initialSelection = "";
            do
            {
                while (menuLoop)
                {
                BeginningOfMainMenu:
                    Console.WriteLine("Mmmm, yes. Lets talk money. You run this town. Lets look at the districts!\n\x1B[4m");

            Console.WriteLine("Please choose an option:\x1B[0m");
            Console.WriteLine("1- Enter Store Sales");
            Console.WriteLine("2- Generate District Report");
            Console.WriteLine("3- Add New Employee");
            Console.WriteLine("4- Add a Store/District");
            Console.WriteLine("5- Exit");

                    initialSelection = Console.ReadLine();
                    switch (initialSelection)
                    {
                        case "1":
                        SalesMenu:
                            //entering sales
                            //TO DO: add sales to dictionary
                            //bool saleLoop = true;
                            Console.Clear();

                            Console.WriteLine("What is the store number?");
                            var storeNumberInput = Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine($"Enter a sales log for Store: {storeNumberInput}.");
                            Console.WriteLine();

                            Console.WriteLine("Enter the Yearly Gas Sales in USD:");
                            var gasYearly = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter this Quarter's Gas Sales in USD:");
                            var gasCurrentQuarter = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the Yearly Retail Sales in USD:");
                            var retailYearly = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter this Quarter's Retail Sales in USD:");
                            var retailCurrentQuarter = int.Parse(Console.ReadLine());

                            Console.WriteLine("Assign a sales id:");
                            var saleId = int.Parse(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine($"{storeNumberInput}-------------\nSold {gasYearly}USD in gas sales, 2020\nSold {gasCurrentQuarter}USD in gas, Q2 2021\nSold {retailYearly}USD in retail sales, 2020\nSold {retailCurrentQuarter}USD in gas, Q2 2021");
                            Console.WriteLine("");

                            Console.Clear();
                            Console.WriteLine("Would you like to save this report, discard it, or return to the main menu? (Please type 'save,' 'discard,' or 'menu.')");
                            var userResponse = Console.ReadLine();
                            switch (userResponse.ToLower())
                            {
                                case "save":
                                    wizardSalesDictionary.Add(saleId, value: new Sale(storeNumberInput, gasYearly, gasCurrentQuarter, retailYearly, retailCurrentQuarter));
                                    Console.Clear();
                                    Console.WriteLine($"You added this sales log for store number {storeNumberInput}");
                                    menuLoop = false;
                                    goto SalesMenu;
                                case "discard":
                                    Console.WriteLine("Cool. It's gone.");
                                    menuLoop = false;
                                    goto SalesMenu;
                                case "menu":
                                    Console.Clear();
                                    goto BeginningOfMainMenu;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid choice");
                                    break;
                            }
                            Console.Clear();
                            goto BeginningOfMainMenu;
                        case "2":
                            Console.WriteLine("WE'RE STILL WORKING ON THIS");
                            break;
                        case "3":
                            Console.WriteLine("We're adding an employee");
                            Console.WriteLine("What is their name? Choose wisely and then press enter.");
                            string name = Console.ReadLine();
                            string position = "";
                            bool startLoop = true;
                            while (startLoop)
                            {
                                Console.WriteLine($"\n\x1B[4m What is {name}'s job title?\x1B[0m ");
                                Console.WriteLine("1. District Manager");
                                Console.WriteLine("2. Store Manager");
                                Console.WriteLine("3. Assistant Manager");
                                Console.WriteLine("4. Associate");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        position = JobType.DistrictManager.ToString();
                                        Console.WriteLine(position);
                                        startLoop = false;
                                        break;
                                    case "2":
                                        position = JobType.StoreManager.ToString();
                                        Console.WriteLine(position);
                                        startLoop = false;
                                        break;
                                    case "3":
                                        position = JobType.AssistantManager.ToString();
                                        Console.WriteLine(position);
                                        startLoop = false;
                                        break;
                                    case "4":
                                        position = JobType.Associate.ToString();
                                        Console.WriteLine(position);
                                        startLoop = false;
                                        break;
                                    default:
                                        Console.WriteLine("That is not a valid answer!");
                                        break;

                        }
                    }
                            var employeeListRepo = new EmployeeRepository();
                            employeeListRepo.Add(new Employee(name, position));
                            var employeeList = employeeListRepo.GetAll();

                            foreach (Employee e in employeeList)
                            {
                                Console.WriteLine($"Name: {e.Name} / Job Title: {e.PositionTitle}");
                            }
                    break;
                case "4":
                    Console.WriteLine("Time to add a store!");
                    Console.WriteLine("What is the name of your store? Please enter a three-digit number");
                    storeNumber = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Your store number is {storeNumber}.");
                            string storeDistrict = "";
        ;                    bool startLoop2 = true;
                    while (startLoop2)
                    {
                        Console.WriteLine($"What district is your store in?");
                        Console.WriteLine("1- Gryffindor");
                        Console.WriteLine("2- Hufflepuff");
                        Console.WriteLine("3- Ravenclaw");
                        Console.WriteLine("4- Slytherin");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                storeDistrict = DistrictType.Gryffindor.ToString();
                                Console.WriteLine(storeDistrict);
                                startLoop2 = false;
                                break;
                            case "2":
                                storeDistrict = DistrictType.Hufflepuff.ToString();
                                Console.WriteLine(storeDistrict);
                                startLoop2 = false;
                                break;
                            case "3":
                                storeDistrict = DistrictType.Ravenclaw.ToString();
                                Console.WriteLine(storeDistrict);
                                startLoop2 = false;
                                break;
                            case "4":
                                storeDistrict = DistrictType.Slytherin.ToString();
                                Console.WriteLine(storeDistrict);
                                startLoop2 = false;
                                break;
                            default:
                                Console.WriteLine("That is not a valid answer!");
                                break;

                        }
                    }

                    var storeRepo = new StoreRepository();
                    storeRepo.Add(new Store { StoreNumber = storeNumber, DistrictHouse = storeDistrict });
                    var storeToLoop = storeRepo.GetAll();

                    foreach (var store in storeToLoop)
                    {
                        Console.WriteLine($"Store Number {store.StoreNumber} is in district {store.DistrictHouse}");
                        Console.WriteLine($"---------------------------------------------------------------------");
                    }

                    break;
                     case "5":
                        initialSelection = "5";
                        Console.Clear();
                        menuLoop = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
            }
            while (initialSelection != "5");
        }
    }
}
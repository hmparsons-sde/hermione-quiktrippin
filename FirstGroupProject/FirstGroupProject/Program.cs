﻿using FirstGroupProject.Districts;
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
            string name;
            string jobTitle;
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

                            Console.WriteLine("Add a new sales log:");
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


                            Console.WriteLine("Would you like to save this report, discard it, or return to the main menu? (Please type 'save,' 'discard,' or 'menu.')");
                            var userResponse = Console.ReadLine();
                            switch (userResponse.ToLower())
                            {
                                case "save":
                                    wizardSalesDictionary.Add(saleId, value: new Sale(storeNumberInput, gasYearly, gasCurrentQuarter, retailYearly, retailCurrentQuarter));
                                    Console.Clear();
                                    Console.WriteLine($"You added this sales log for store number {storeNumberInput}");
                                    menuLoop = false;
                                    break;
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
                    Console.WriteLine("Time to add a store!");
                    Console.WriteLine("What is the name of your store? Please enter a three-digit number");
                    storeNumber = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Your store number is {storeNumber}. Please press enter to continue.");
                    string storeDistrict = Console.ReadLine();
                    bool startLoop2 = true;
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
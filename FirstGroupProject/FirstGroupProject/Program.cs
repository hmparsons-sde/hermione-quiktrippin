using FirstGroupProject.Employees;
using FirstGroupProject.StoreSales;
using System;
using System.Collections.Generic;
using static FirstGroupProject.StoreSales.Sale;

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

            // dummy sales data
            //sales people to create dictionary of sales for storage
            //var Hermione = new SalesWizard();
            //var Ron = new SalesWizard();
            //var Harry = new SalesWizard();
            //var Neville = new SalesWizard();

            //var SalesWizards = new List<SalesWizard>
            //{
            //    Hermione,
            //    Ron,
            //    Harry,
            //    Neville,
            //};

            //var hermioneSale = new Sale(1, 10, 11850, 2490, 11190, 2698);
            //var ronSale = new Sale(2, 20, 9880, 1098, 15460, 4444);
            //var harrySale = new Sale(3, 30, 5555, 32000, 4000, 29000);
            //var nevilleSale = new Sale(4, 40, 4646, 8800, 2000, 10000);

            //Hermione.SalesDictionary.Add(hermioneSale.SaleId, hermioneSale);
            //Ron.SalesDictionary.Add(ronSale.SaleId, ronSale);
            //Harry.SalesDictionary.Add(harrySale.SaleId, harrySale);
            //Neville.SalesDictionary.Add(nevilleSale.SaleId, nevilleSale);
            //// end dummy sales data

            Console.WriteLine("Mmmm, yes. Lets talk money. You run this town. Lets look at the districts!\n\x1B[4m");

            Console.WriteLine("Please choose an option:\x1B[0m");
            Console.WriteLine("1- Enter Store Sales");
            Console.WriteLine("2- Generate District Report");
            Console.WriteLine("3- Add New Employee");
            Console.WriteLine("4- Add a Store");
            Console.WriteLine("5- Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Dictionary<int, Sale> wizardSalesDictionary = new();
                    //foreach (var wizard in SalesWizards)
                    //{
                    //    foreach (var sale in wizard.SalesDictionary)
                    //    {
                    //        wizardSalesDictionary.Add(sale.Key, sale.Value);
                    //    }
                    //}
                    Console.WriteLine("What is the store number?");
                    // these counts will index the sales by sales id, so that they will be saved and can be accessed later.
                    //var valueCount = 1;
                    //foreach (var wizard in SalesWizards)
                    //{
                    //    Console.WriteLine($"{valueCount}. {wizard.StoreNumber}");
                    //    valueCount++;
                    //}
                    var storeNumberInput = Console.ReadLine();
                    //var specificStoreSaleLog = SalesWizards[(Int32.Parse(storeNumberInput) - 1)];
                    Console.Clear();
                    Console.WriteLine($"Enter a sales log for {storeNumberInput}.");
                    Console.WriteLine();
                    Console.WriteLine("Enter the Yearly Gas Sales in USD:");
                    var gasYearly = short.Parse(Console.ReadLine());
                    Console.WriteLine("Enter this Quarter's Gas Sales in USD:");
                    var gasCurrentQuarter = short.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Yearly Retail Sales in USD:");
                    var retailYearly = short.Parse(Console.ReadLine());
                    Console.WriteLine("Enter this Quarter's Retail Sales in USD:");
                    var retailCurrentQuarter = short.Parse(Console.ReadLine());
                    Console.WriteLine("Assign a sales id:");
                    var saleId = short.Parse(Console.ReadLine());

                    //specificStoreSaleLog.SalesDictionary.Add(saleId, value: new Sale(
                    //    specificStoreSaleLog.StoreNumber, gasYearly, gasCurrentQuarter, retailYearly, retailCurrentQuarter));

                    Console.Clear();

                    Console.WriteLine($"{storeNumberInput}-------------\nSold {gasYearly}USD in gas sales, 2020\nSold {gasCurrentQuarter}USD in gas, Q2 2021\nSold {retailYearly}USD in retail sales, 2020\nSold {retailCurrentQuarter}USD in gas, Q2 2021");
                    Console.WriteLine("");
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
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

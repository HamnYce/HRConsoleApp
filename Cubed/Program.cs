using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;



namespace HRprog
{

    

    class Program
    {
        static List<Employee> employeeList = new List<Employee>();
        public static int ind = 0;

        static void Main(string[] args)
        {
            
            Console.Clear();
            
            //Main containers, than act like registers. set n,a,i then set them to as new employees properties
            
            string option;
            bool switchout = false;
            //List<Employee> employeeList = new List<Employee>();

            do
            {
                
                Console.WriteLine("Press:\n1 to add employee,\n2 to display employees,\n3 to delete,\n4 to edit,\n0 to exit application (all data will be deleted on exit).");
                option = Console.ReadLine();


                switch (option)
                {

                    

                    case "1"://add employee
                        employeeAdd();

                        break;


                    case "2"://view employee list
                        employeeView();

                        break;

                    case "3"://delete specific employee
                        employeeDelete();

                        break;

                    case "4"://edit name or age
                        employeeEdit();

                        break;

                    case "5"://search by name or age
                        employeeSearch();

                        break;
 

                    case "0"://exit switch loop
                        switchout = true;

                        break;

                    default:
                        Console.WriteLine("Please enter a valid input.");
                        break;

                }//switch Bracket
                
            } while (switchout == false);

        }//Main Bracket
                

            



        public static void employeeAdd()
        {

            
                string n;
                int a;
                
                
                Console.WriteLine("Please input the employee's name and age.");
                


                Console.Write("Please enter NAME of the employee: ");
                n = Console.ReadLine();


                Console.Write("Please enter AGE of the employee: ");
                a = Convert.ToInt32(Console.ReadLine());



                employeeList.Add(new Employee() {Name = n, Age = a });

                
                
                
                

            


        }
        
        public static void employeeView()
        {
            
            int counter = 0;
            foreach (Employee e in employeeList)
            {
                if (employeeList[counter].Status == true)

                {

                    Console.WriteLine("index: " + counter + " " + e);
                    counter++;
                }

                else
                {
                    Console.Write("");
                    counter++;
                }
                
               

            }
        }

        public static void employeeDelete()
        {
            int n;
            Console.WriteLine("Please enter the index of the employee you like to delete");

            n = Convert.ToInt32(Console.ReadLine());

            employeeList[n].Status = false;

        }

        public static void employeeEdit()
        {
            
            bool switchout = false;
            
            do
            {
                Console.WriteLine("edit:\n1 name\n2 age");
                string option = Console.ReadLine();
                
                switch (option)
                {
                    case "1"://edit name of specific employee

                        Console.WriteLine("please enter index of employee you want to edit");
                        int n = Convert.ToInt32(Console.ReadLine());

                        Console.Write("now please enter the new name: ");
                        string newname = Console.ReadLine();

                        employeeList[n].Name = newname;
                        Console.WriteLine(employeeList[n]);

                        switchout = true;
                        break;

                    case "2"://edit age of specific employee

                        Console.WriteLine("please enter index of employee you want to edit");
                        n = Convert.ToInt32(Console.ReadLine());

                        Console.Write("now please enter the new age: ");
                        int newage = Convert.ToInt32(Console.ReadLine());

                        employeeList[n].Age = newage;
                        Console.WriteLine(employeeList[n]);

                        switchout = true;
                        break;

                    default:

                        Console.WriteLine("Please enter a valid input.");

                        break;
                }
            } while (switchout == false);
        }

        public static void employeeSearch()
        {
            bool switchout = false;

            Console.WriteLine("Would you like to search by 1. name or 2.age");
            string option = Console.ReadLine();

            do
            {
                switch (option)
                {
                    case "1":



                        List<Employee> results = employeeList.FindAll(findName);
                        if (results.Count != 0)
                        {
                            displayResult(results, "aall");
                        }
                        else
                        {
                            Console.WriteLine("nope");
                        }


                        

                        

                        break;

                    case "2":
                        
                        break;

                    default:
                        Console.WriteLine("please enter a valid input");
                        break;
                }
            } while (switchout == false);

        }


        public static bool findName(Employee en)
        {
            

            if (en.Name == "jack")
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public static void displayResult(Employee result, string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("{0} {1}", result.Name, result.Age);

        }


    }//Program Bracket

   


    class Employee
    {//does it matter which variable i use? name vs Name?
        public override string ToString()
        {
            return "   Name: " + Name + "   Age: " + age;
        }

        
        string name;
        int age;
        bool status = true;

        
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool Status { get => status; set => status = value; }
    }
    

}//Namespace Bracket

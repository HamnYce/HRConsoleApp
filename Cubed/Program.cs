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
                
                Console.WriteLine("Press:\n1 to add employee,\n2 to display all employees (with index),\n3 to delete,\n4 to edit,\n5 to search employee by age or name,\n0 to exit application (WARNING: all data will be deleted on exit).");
                option = Console.ReadLine();


                switch (option)
                {

                    

                    case "1"://add employee
                        employeeAdd();

                        break;


                    case "2"://view all employee list
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
            bool switchout = false;
            string option;
            do
            {
                Console.WriteLine("Press enter to begin deletion or press 0 to exit back to main menu.");
                option = Console.ReadLine();
                switch (option)
                {

                    case "":

                        
                        Console.WriteLine("Please enter the index of the employee you like to delete");

                        int n = Convert.ToInt32(Console.ReadLine());

                        employeeList[n].Status = false;

                        switchout = true;

                        break;


                    case "0":

                        switchout = true;

                        break;


                    default:
                        Console.WriteLine("please enter one of the two possible inputs");
                        break;

                }
            } while (switchout == false);
        
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
            do
            {
                Console.WriteLine("Would you like to search by 1. name or 2.age");
                string option = Console.ReadLine();

            
                switch (option)
                {
                    case "1":

                        Console.WriteLine("please input employee search name: ");
                        string searchnameparam = Console.ReadLine();

                        searchNameLog(searchnameparam);
                        

                        break;

                    case "2":
                        Console.WriteLine("please input employee search age: ");
                        int searchageparam = Convert.ToInt32(Console.ReadLine());

                        searchAgeLog(searchageparam);
                        
                        break;

                    case "0":
                        Console.WriteLine("bye");
                        switchout = true;
                        break;

                    default:
                        Console.WriteLine("please enter a valid input");
                        break;
                }
            } while (switchout == false);

        }
 
         public static void searchNameLog(string namesearch)
        {
            
            for (int i =0; i < employeeList.Count; i++)
            {
                int indexprint = 0;
                if (employeeList[i].Name == namesearch)
                {
                     Console.WriteLine("Employee Index: ",indexprint , " name: " + employeeList[i].Name + " Age: " + employeeList[i].Age);
                    indexprint++;
                }
                
            }
            

        }

        public static void searchAgeLog(int agesearch)
        {
            int indexprint = 0;
            for (int i = 0; i < employeeList.Count; i++)
            {

                if (employeeList[i].Age == agesearch)
                {

                    Console.WriteLine("employee Index: ",indexprint, " name: " + employeeList[i].Name + " Age: " + employeeList[i].Age);
                    indexprint++;

                }

            }

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

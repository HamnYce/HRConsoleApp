using System;
using System.Collections.Generic;

namespace HRprog
{

    

    class Program
    {
        static List<Employee> employeeList = new List<Employee>();
        public static int ind = 0;

        static void Main(string[] args)
        {
            
            //Main containers, than act like registers. set n,a,i then set them to as new employees properties
            
            string option;
            //List<Employee> employeeList = new List<Employee>();
            
            
            Console.WriteLine("Press,1 to add employee, 2 to display employees,3 to edit, 4 to delete");
            option = Console.ReadLine();


            switch (option)
            { 
            //add employee
               
            
                case "1":
                    employeeAdd();

                break;
                    
            }//switch Bracket

            Console.WriteLine(employeeList[0]);

        }//Main Bracket
                

            /*
                            //view employee list
                            case "2":
                                break;


                            //edit employee, from employee list ("which employee would you like to edit")
                            case "3":
                                break;


                            //delete employee from the list
                            case "4":
                                break;

                            default:
                                Console.WriteLine("I didn't quite get that");
                                break;
            */
           

            
        public static void employeeAdd()
        {

            bool choice = true;

            
                string n;
                int a;
                int i;
                //List<Employee> employeeList = new List<Employee>();
                

                Console.WriteLine("Please input the employees name, age, and ID.");
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();
                Console.Clear();


                Console.Write("Please enter ID of the employee: ");
                i = Convert.ToInt32(Console.ReadLine());


                Console.Write("Please enter name of the employee: ");
                n = Console.ReadLine();


                Console.Write("Please enter age of the employee: ");
                a = Convert.ToInt32(Console.ReadLine());



                employeeList.Add(new Employee() { Id = i, Name = n, Age = a });

                foreach (Employee e in employeeList)
                {
                    Console.WriteLine("index: " + ind + " " + e);
                    ind++;

                }

                Console.WriteLine("Would you like to add another employee? (true/false)");
                choice = Convert.ToBoolean(Console.ReadLine());

            


        }








    }//Program Bracket




    class Employee
    {//does it matter which variable i use? name vs Name?
        public override string ToString()
        {
            return "ID: " + Id + "   Name: " + Name + "   Age: " + age;
        }

        int id;
        string name;
        int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
    

}//Namespace Bracket

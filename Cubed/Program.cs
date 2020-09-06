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
            bool switchout = false;
            //List<Employee> employeeList = new List<Employee>();

            do
            {
                
                Console.WriteLine("Press:\n1 to add employee,\n2 to display employees,\n3 to edit,\n4 to delete,\n0 to exit application.");
                option = Console.ReadLine();


                switch (option)
                {



                    case "1"://add employee
                        employeeAdd();

                        break;


                    case "2"://view employee list
                        employeeView();

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
                

            
                            //view employee list
                           
            /*

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

            

            
                string n;
                int a;
                
                //List<Employee> employeeList = new List<Employee>();
                
                
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
                
                Console.WriteLine("index: " + employeeList[counter]+ " " + e);
                counter++;

            }
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

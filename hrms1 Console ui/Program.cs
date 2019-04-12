using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_business_lib;
using hrms_entities_lib;

namespace hrms1_Console_ui
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Employee emp;
            HrmsBusiness bll = new HrmsBusiness();
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Remove Employee");
                Console.WriteLine("3.Update Employee");
                Console.WriteLine("4.display All Employee");
                Console.WriteLine("5.Display Employee by id");
                Console.WriteLine("6.exit");
                Console.WriteLine("enter your choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        emp = new Employee();
                        Console.WriteLine("enter ecode");
                        emp.Ecode = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter ename");
                        emp.Ename = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        emp.salary = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter deptid");
                        emp.deptid = int.Parse(Console.ReadLine());
                        bll.AddEmployee(emp);
                        Console.WriteLine("record inserted");
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.WriteLine("enter ecode");
                        bll.RemoveEmpById(int.Parse(Console.ReadLine()));
                        //record deleted
                        break;

                    case 3:
                        Console.WriteLine("enter ecode");
                        int ecode = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter salary");
                        int salary = int.Parse(Console.ReadLine());
                        bll.UpdateEmpById(ecode, salary);
                        break;

                    case 4:
                        //get all the employee using business layer
                        List<Employee> result = bll.GetAllEmps();
                        //dispaly result
                        foreach (Employee e in result)
                        {
                            Console.WriteLine(e.Ecode + "\t" + e.Ename + "\t" + e.salary + "\t" + e.deptid);
                        }
                        break;

                    case 5:
                        emp = new Employee();
                        Console.WriteLine("enter ecode");
                        ecode = int.Parse(Console.ReadLine());
                        emp = bll.GetEmpById(ecode);
                        Console.WriteLine(emp.Ecode + "\t" + emp.Ename + "\t" + emp.salary + "\t" + emp.deptid);
                        break;


                    default:
                        Console.WriteLine("incorrect choice");
                        break;

                }

            } while (choice!=6);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_entities_lib;

namespace hrms_dataaccess_lib
{
     interface IhrmsDataAccess
    {
        void InsertEmployee(Employee emp);
        void DeleteEmpById(int ecode);
        void UpdateEmpById(int ecode,int salary);
        List<Employee> SelectAllEmps();
        Employee SelectEmpById(int ecode);

        void InsertStudent(Student std);
        List<Student> SelectAllstd();
    }
    public class HrmsDataAccess : IhrmsDataAccess
    {
        List<Employee> lstemp;
        List<Student> lststd;
        public HrmsDataAccess()
        {
            lstemp = new List<Employee>();
            lststd = new List<Student>();
        }

        public void DeleteEmpById(int ecode)
        {
            for(int i=0;i<lstemp.Count;i++)
            {
                if(lstemp[i].Ecode!=ecode)
                {
                    Console.Write("enter valid ecode");
                }else
                if(lstemp[i].Ecode==ecode)
                {
                    //deleting emp details
                    lstemp.RemoveAt(i);
                    break;
                }
            }
        }

        public void InsertEmployee(Employee emp)
        {
            //inserting emp details
            lstemp.Add(emp);
        }

        public void InsertStudent(Student std)
        {
            lststd.Add(std);
        }

        public List<Employee> SelectAllEmps()
        {
            List<Employee> result = new List<Employee>();
            result = lstemp;
            return result;
        }

        public List<Student> SelectAllstd()
        {
            List<Student> result = new List<Student>();
            result = lststd;
            return result;
        }

        public Employee SelectEmpById(int ecode)
        {
            Employee result =null;
            foreach (Employee e in lstemp)
            {
                if(e.Ecode != ecode)
                {
                    Console.Write("enter valid ecode");
                }else
                if (e.Ecode == ecode)
                {
                    result = e;
                    break;
                }
            }
            return result;
        }

        public void UpdateEmpById(int ecode, int salary)
        {
            for(int i=0;i<lstemp.Count;i++)
            {
                if(lstemp[i].Ecode != ecode)
                {
                    Console.Write("enter correct ecode");
                }else
                if(lstemp[i].Ecode == ecode)
                {
                    //update salary
                    lstemp[i].salary = salary;
                    break;
                }
            }
        }
    }
}

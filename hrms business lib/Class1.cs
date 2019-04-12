using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_entities_lib;
using hrms_dataaccess_lib;

namespace hrms_business_lib
{
    interface IhrmsBusiness
    {
        void AddEmployee(Employee emp);
        void RemoveEmpById(int ecode);
        void UpdateEmpById(int ecode, int salary);

        List<Employee> GetAllEmps();
        Employee GetEmpById(int ecode);

        //void AddStudent(Student std);
        //List<Student> GetAllStd();

        //void UpdateSalaryUsingSP(int ecode, int salary);
        //double GetBonus(int salary);

        //void DoTransaction();


    }
    public class HrmsBusiness : IhrmsBusiness
    {
        // HrmsDataAccess dal;
       
        HrmsAdoDisconnected dal;
        public HrmsBusiness()
        {
            // dal = new HrmsDataAccess();
            dal = new HrmsAdoDisconnected();
        }
        public void AddEmployee(Employee emp)
        {
            dal.InsertEmployee(emp);
        }

        //public void AddStudent(Student std)
        //{
        //    dal.InsertStudent(std);
        //}

        //public void DoTransaction()
        //{
        //    dal.DoTransaction();
        //}

        public List<Employee> GetAllEmps()
        {
            List<Employee> lstemp;
            lstemp = dal.SelectAllEmps();
            return lstemp;
        }

        //public List<Student> GetAllStd()
        //{
        //   List<Student> lststd;
        //    lststd = dal.SelectAllStd();
        //    return lststd;

        //}

        //public double GetBonus(int salary)
        //{
        //    double bonus = 0;
        //    bonus = dal.GetBonus(salary);
        //    return bonus;
        //}

        public Employee GetEmpById(int ecode)
        {
            Employee emp;
            emp = dal.SelectEmpById(ecode);
            return emp;
        }

        public void RemoveEmpById(int ecode)
        {
            dal.DeleteEmpById(ecode);
        }

        public void UpdateEmpById(int ecode, int salary)
        {
            dal.UpdateEmpById(ecode, salary);
        }

        //public void UpdateSalaryUsingSP(int ecode, int salary)
        //{
        //    dal.UpdateSalaryUsingSP(ecode,salary);
        //}

      
    }
}

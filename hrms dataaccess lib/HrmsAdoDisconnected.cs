using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using hrms_entities_lib;

namespace hrms_dataaccess_lib
{
    interface IHrmsAdoDisConnected
    {
        void InsertEmployee(Employee emp);
        void DeleteEmpById(int ecode);
        void UpdateEmpById(int ecode, int salary);
        List<Employee> SelectAllEmps();
        Employee SelectEmpById(int ecode);
    }
    public class HrmsAdoDisconnected : IHrmsAdoDisConnected
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public HrmsAdoDisconnected()
        {
            //configure connection
            con = new SqlConnection();
            con.ConnectionString= "Data Source=.;Initial Catalog=IBMDB;User ID=sa;Password=password@123";

            //configure data adapter
            da = new SqlDataAdapter("select * from employee",con);

            //create data set
            ds = new DataSet();

            //fill the dataset using data adapter           
            da.Fill(ds, "employee");

            //add the constraint
            ds.Tables[0].Constraints.Add("pk1", ds.Tables[0].Columns[0],true);
        }

        public void DeleteEmpById(int ecode)
        {
            //find the record to be deleted based on key column
           DataRow rows= ds.Tables[0].Rows.Find(ecode);
            if(rows==null)
            {
                throw new Exception("ecode doesnt exist");
            }
            else
            {
                //when primary key is not there in the table
                SqlCommand cmdDel = new SqlCommand();
                cmdDel.CommandText = "delete from employee where ecode"+ecode;
                cmdDel.Parameters.Clear();
                cmdDel.Parameters.AddWithValue("@Ecode", ecode);
                da.DeleteCommand = cmdDel;


                //when primary key is there in table
                rows.Delete();
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "employee");
            }




            //find the record to be deleted from the dataset table
            //DataRow[] row=  ds.Tables[0].Select("ecode=" + ecode);
            //if (row.Length == 0)
            //{
            //    throw new Exception("ecode doesnt exist");
            //}
            //else
            //{
            //    row[0].Delete();
            //    //save the changes to db using data adapter
            //    SqlCommandBuilder cb = new SqlCommandBuilder(da);
            //    da.Update(ds, "employee");
            //}
        }

        public void InsertEmployee(Employee emp)
        {
            //create new row as per data set table
            DataRow row = ds.Tables[0].NewRow();

            //supplie values to the columns of the new row created
            row[0] = emp.Ecode;
            row[1] = emp.Ename;
            row[2] = emp.salary;
            row[3] = emp.deptid;

            //add the new row to the rows of the data table  of ds
            ds.Tables[0].Rows.Add(row);

            //save the record to the database using data adapter
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "employee");
        }

        public List<Employee> SelectAllEmps()
        {
            List<Employee> lstemp = new List<Employee>();
            //traverse the data set for rows
            foreach(DataRow row in ds.Tables[0].Rows)
                {
                //create employee using each row values
                Employee emp = new Employee
                {
                    Ecode = (int)row[0],
                    Ename = (string)row[1],
                    salary=(int)row[2],
                    deptid=(int)row[3]
                };
                //add the employee to the collection
                lstemp.Add(emp);
                }
            return lstemp;
        }

        public Employee SelectEmpById(int ecode)
        {
            Employee emp = null;
            DataRow row = ds.Tables[0].Rows.Find(ecode);
            if(row==null)
            {
                throw new Exception("ecode doesnt exist");

            }
            else
            {
                emp = new Employee()
                {
                    Ecode=(int)row[0],
                    Ename=row[1].ToString(),
                    salary= (int)row[2],
                    deptid= (int)row[3],
                };
            }
            return emp;
        }

        public void UpdateEmpById(int ecode, int salary)
        {
            //find the record to be deleted from the dataset table
            DataRow[] row = ds.Tables[0].Select("ecode=" + ecode);
            if (row.Length == 0)
            {
                throw new Exception("ecode doesnt exist");
            }
            else
            {
                row[0][2] =(int)row[0][2]+ salary;
                //save the changes to db using data adapter
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "employee");
            }
        }
    }
}

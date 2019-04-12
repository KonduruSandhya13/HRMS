using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_entities_lib;
using System.Data.SqlClient;//ADO.Net classes
using System.Data;

namespace hrms_dataaccess_lib
{
    interface IHrmsAdoConnected
    {
        void InsertEmployee(Employee emp);
        void DeleteEmpById(int ecode);
        void UpdateEmpById(int ecode, int salary);
        List<Employee> SelectAllEmps();
        Employee SelectEmpById(int ecode);

        void InsertStudent(Student std);

        void UpdateSalaryUsingSP(int salary,int ecode);
        //parameter direction
        double GetBonus(int salary);

        void DoTransaction();

    }
    public class HrmsAdoConnected : IHrmsAdoConnected
    {
        SqlConnection con;
        SqlCommand cmd;

        public HrmsAdoConnected()
        {
            //configure the connection
            con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=IBMDB;User ID=sa;Password=password@123";
            //configure command and attach connection
            cmd = new SqlCommand();
            cmd.Connection = con;
        }



        public void DeleteEmpById(int ecode)
        {
            try
            {
                //configure command text DELETE by ecode
                cmd.CommandText = "delete from employee where ecode=" + ecode;
                cmd.CommandType = CommandType.Text;

                //open connection
                con.Open();
                //execute the command
                int RecordsAffected = cmd.ExecuteNonQuery();



            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //close the connection
                con.Close();
            }


        }

        public List<Student> SelectAllStd()
        {
            List<Student> lststd = null;
            try
            {
                //configure cmd text for SELECT ALL
                cmd.CommandText = "select * from student";
                cmd.CommandType = CommandType.Text;
                //open connection
                con.Open();
                //execute the command               
                SqlDataReader sdr = cmd.ExecuteReader();
                lststd = new List<Student>();
                while (sdr.Read())
                {
                    //read the current records column values and create employee object
                    Student std = new Student()
                    {
                        id = (int)sdr[0],
                        StudentName = sdr[1].ToString(),
                        Age = (int)sdr[2],
                        ClassTeacherId = (int)sdr[3]
                    };
                    //add the employee obj to the collection
                    lststd.Add(std);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lststd;
        }


        public void InsertEmployee(Employee emp)
        {
            try
            {
                //configure cmd text for insert operation
                // cmd.CommandText = "insert into employee values("+emp.Ecode+",'"+emp.Ename+"',"+emp.salary+","+emp.deptid+")";
                cmd.CommandText = "insert into employee values(@Ecode,@Ename,@Salary,@Deptid)";
                cmd.CommandType = CommandType.Text;
                //configure command parameters and values
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Ecode", emp.Ecode);
                cmd.Parameters.AddWithValue("@Ename", emp.Ename);
                cmd.Parameters.AddWithValue("@Salary", emp.salary);
                cmd.Parameters.AddWithValue("@Deptid", emp.deptid);

                //open the connection
                con.Open();
                //execute the command           
                int recordsAffected = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //close the connection
                con.Close();
            }

        }

        public void InsertStudent(Student std)
        {

            try
            {
                //configure cmd text for insert operation
                // cmd.CommandText = "insert into employee values("+emp.Ecode+",'"+emp.Ename+"',"+emp.salary+","+emp.deptid+")";
                cmd.CommandText = "insert into student values(@id,@StudentName,@Age,@ClassTeacherId)";
                cmd.CommandType = CommandType.Text;
                //configure command parameters and values
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", std.id);
                cmd.Parameters.AddWithValue("@StudentName", std.StudentName);
                cmd.Parameters.AddWithValue("@Age", std.Age);
                cmd.Parameters.AddWithValue("@ClassTeacherId", std.ClassTeacherId);

                //open the connection
                con.Open();
                //execute the command           
                int recordsAffected = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //close the connection
                con.Close();
            }

        }


        public List<Employee> SelectAllEmps()
        {
            List<Employee> lstemps = null;
            try
            {
                //configure cmd text for SELECT ALL
                cmd.CommandText = "select * from employee";
                cmd.CommandType = CommandType.Text;
                //open connection
                con.Open();
                //execute the command               
                SqlDataReader sdr = cmd.ExecuteReader();
                lstemps = new List<Employee>();
                while (sdr.Read())
                {
                    //read the current records column values and create employee object
                    Employee emp = new Employee()
                    {
                        Ecode = (int)sdr[0],
                        Ename = sdr[1].ToString(),
                        salary = (int)sdr[2],
                        deptid = (int)sdr[3]
                    };
                    //add the employee obj to the collection
                    lstemps.Add(emp);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lstemps;
        }
        public Employee SelectEmpById(int ecode)
        {
            Employee emp = null;
            try
            {
                //configure command text SELECT by ecode
                cmd.CommandText = "select * from employee where ecode=" + ecode;
                cmd.CommandType = CommandType.Text;

                //open connection
                con.Open();
                //execute the command
                SqlDataReader sdr = cmd.ExecuteReader();

                //take the values of the record columns into employee obj

                if (sdr.Read())
                {
                    emp = new Employee()
                    {
                        Ecode = (int)sdr[0],
                        Ename = sdr[1].ToString(),
                        salary = (int)sdr[2],
                        deptid = (int)sdr[3]
                    };
                    sdr.Close();
                }
                else
                {
                    throw new Exception("ecode doesnt exist");
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return emp;
        }


        public void UpdateEmpById(int ecode, int salary)
        {
            try
            {
                //configure command text UPDATE by ecode
                cmd.CommandText = "update  employee set salary=" + salary + "where ecode=" + ecode;
                cmd.CommandType = CommandType.Text;
                //open connection
                con.Open();
                //execute the command
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    throw new Exception("ecode doesnt exist");
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //close the connection
                con.Close();
            }

        }


        public void UpdateSalaryUsingSP(int ecode, int salary)
        {
            try
            {
                //configure the command text for stored procedure
                cmd.CommandText = "sp_UpdateSalaryById";

                //specify cmd type mandatorily
                cmd.CommandType = CommandType.StoredProcedure;

                //configure the parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ecode", ecode);
                cmd.Parameters.AddWithValue("@salary", salary);

                //open connection
                con.Open();
                cmd.ExecuteNonQuery();



            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public double GetBonus(int salary)
        {
            cmd.CommandText = "sp_calcbonus";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();          
            cmd.Parameters.AddWithValue("@salary", salary);
            double bonus = 0;
            cmd.Parameters.AddWithValue("@bonus", bonus);
           
            //configure directions of parameters
            cmd.Parameters[1].Direction = ParameterDirection.Output;
            con.Open();
            cmd.ExecuteNonQuery();

            //get the updated value of bonus parameter out of sp
            bonus = (double)cmd.Parameters[1].Value;
            con.Close();
            return bonus;

        }

        public void DoTransaction()
        {
            SqlTransaction t = null;
            try
            {
                SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();

                cmd1.CommandText = "delete from employee where ecode=101";
                cmd2.CommandText = "update employee set salary=salary+1000 where ecode =102";

                cmd1.Connection = con;
                cmd2.Connection = con;

                con.Open();
                t = con.BeginTransaction();
                cmd1.Transaction = t;
                cmd2.Transaction = t;

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                t.Commit();

            }
            catch(SqlException ex)
            {
                t.Rollback();
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}



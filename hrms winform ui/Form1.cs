using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hrms_entities_lib;
using hrms_business_lib;

namespace hrms_winform_ui
{
    public partial class Form1 : Form
    {
        HrmsBusiness bll;
       
        public Form1()
        {
            bll = new HrmsBusiness();
            InitializeComponent();
        }

        private void btnFindEmp_Click(object sender, EventArgs e)
        {

            Employee emp;
            int ecode = int.Parse(txtEcode.Text);
            emp = null;
            emp = bll.GetEmpById(ecode);
            if (bll.GetEmpById(ecode) == null)
            {
                MessageBox.Show("enter valid ecode");
            }
            else
            {
                MessageBox.Show(emp.Ecode + "\t" + emp.Ename + "\t" + emp.salary + "\t" + emp.deptid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int ecode = int.Parse(txtEcode.Text);
                //if (bll.GetEmpById(ecode) == null)
                //{
                //    MessageBox.Show("record is null");
                //}
                //else
                //{
                    bll.RemoveEmpById(ecode);
                    MessageBox.Show("record DELETED");
                //}
                List<Employee> result = bll.GetAllEmps();
                dgvEmp.DataSource = null;
                dgvEmp.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show ("deosnt exists");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ecode = int.Parse(txtEcode.Text);
                int salary = int.Parse(txtSalary.Text);
                bll.UpdateEmpById(ecode, salary);
                List<Employee> result = bll.GetAllEmps();
                dgvEmp.DataSource = null;
                dgvEmp.DataSource = result;
            }catch(Exception ex)
            {
                MessageBox.Show("ecode doesnt exist");
            }

        }

        private void btnAddemp_Click(object sender, EventArgs e)
        {
            //take input form text boxes
            Employee emp = new Employee
            {
                Ecode =int.Parse(txtEcode.Text),
                Ename=txtEname.Text,
                salary=int.Parse(txtSalary.Text),
                deptid=int.Parse(txtDeptid.Text)
            };

            //Add record using business layer
            bll.AddEmployee(emp);
            MessageBox.Show("record inserted");

            //display all data in data grid view
            List<Employee> result = bll.GetAllEmps();
            dgvEmp.DataSource=null;
            dgvEmp.DataSource = result;
        }

        private void btnCallSp_Click(object sender, EventArgs e)
        {
            int ecode = int.Parse(txtEcode.Text);
            int salary = int.Parse(txtSalary.Text);
           // bll.UpdateSalaryUsingSP(ecode, salary);
            MessageBox.Show("salary updated by using stored procedure");
            List<Employee> result = bll.GetAllEmps();
            dgvEmp.DataSource = null;
            dgvEmp.DataSource = result;
        }

        private void btnGetBonus_Click(object sender, EventArgs e)
        {
            int salary;
           // double bonus;
            salary = int.Parse(txtSalary.Text);
           // bonus = bll.GetBonus(salary);
            //MessageBox.Show("bonus:" + bonus);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                //bll.DoTransaction();
                MessageBox.Show("transaction complete");
            }
            catch(Exception ex)
            {
                MessageBox.Show("transaction is rollback"+ex.Message);

            }
        }

        private void btnDisaplayAll_Click(object sender, EventArgs e)
        {
            List<Employee> emplst = bll.GetAllEmps();
            dgvEmp.DataSource = null;
            dgvEmp.DataSource = emplst;
        }

    }
}

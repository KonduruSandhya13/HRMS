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
    public partial class Student1 : Form
    {
        HrmsBusiness bll;
        public Student1()
        {
            bll = new HrmsBusiness();
            InitializeComponent();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            Student std = new Student
            {
                id = int.Parse(txtid.Text),
                StudentName= txtStdName.Text,
                Age=int.Parse(txtAge.Text),
                ClassTeacherId=int.Parse(txtTeacherId.Text)
            };
            //bll.AddStudent(std);
            MessageBox.Show("record inserted");

            //display all data in data grid view
           // List<Student> result = bll.GetAllStd();
            dgvstd.DataSource = null;
           // dgvstd.DataSource = result;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnFindById_Click(object sender, EventArgs e)
        {

        }
    }
}

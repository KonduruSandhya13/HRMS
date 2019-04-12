using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_entities_lib
{
    [Serializable]
    public class Employee
    {
        public int Ecode { get; set; }
        public string Ename { get; set; }
        public int salary { get; set; }
        public int deptid { get; set; }
    }
    [Serializable]
    public class Student
    {
        public int id { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int ClassTeacherId { get; set; }
    }
}

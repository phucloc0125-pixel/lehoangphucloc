using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Student
    {
       private string name;
        private int age;
        private string studentID;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public String StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public Student(string name, int age, string studentID)
        {
            this.name = name;
            this.age = age;
            this.studentID = studentID;
        }
        public Student()
        {
            this.name = "";
            this.age = 0;
            this.studentID = "";
        }   
        


        public void show()
        {
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("Tuoi: " + age);
            Console.WriteLine("Ma hoc sinh: " + studentID);
        }




    }
}

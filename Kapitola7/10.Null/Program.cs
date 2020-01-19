using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Null
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Pavel", "Novak");
            Student student2 = null;
            Console.WriteLine(student1.Jmeno);
            Console.WriteLine(student2.Jmeno);
        }

        static void VypisInformace(Student student)
        {
            if (student != null)
            {
                Console.WriteLine("Student");
                Console.WriteLine("Jmeno: {0}",student.Jmeno);
                Console.WriteLine("Prijmeni: {0}",student.Prijmeni);
            }
        }
    }

    class Student
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public Student(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
    }
}

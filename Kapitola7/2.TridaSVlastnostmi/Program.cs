using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TridaSVlastnostmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Student pavel = new Student();
            Student petr = new Student();
            Student anna = new Student();
        }
    }

    class Student
    {
        string jmeno;
        string prijmeni;
        int rocnik;
    }
}

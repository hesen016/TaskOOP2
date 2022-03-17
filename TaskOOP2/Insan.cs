using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP2
{
    internal class Insan
    {
        string name;
        string surname;
        int birth_year;

        public string Name { get => name; set =>  name = value.ToUpper(); }
        public string Surname { get => surname; set => surname = value.ToUpper(); }
        public int Birth_year { get => birth_year; set =>birth_year = Math.Abs(value); }



        public int GetAge(int year)
        {
            int age = DateTime.Now.Year - year;
            return age;
        }


    }
}
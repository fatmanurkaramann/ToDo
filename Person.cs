using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Person
    {
        private string name;
        private string surname;
        private int Id;

        public Person(string name, string surname, int ıd)
        {
            this.name = name;
            this.surname = surname;
            Id = ıd;
        }
        public Person() { }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Id1 { get => Id; set => Id = value; }
    }
}

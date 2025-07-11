using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Parent
    {
        private int id;
        private string name;
        protected double height;

        public int Id {  get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        protected double Height { get { return height; } set { height = value; } }

        public Parent()
        {
            //Id = 100;
            //Name = "Ramesh";
            Height = 5.5;
            Console.WriteLine("In the parent default constructor");
        }

        public Parent(int id, string name, double height)
        {
            Id = id;
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Height: {Height}";
        }
    }
}

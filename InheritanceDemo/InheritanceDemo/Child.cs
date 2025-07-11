using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Child : Parent
    {
        public string College { get; set; }

        public Child()
        {
            Height = 5.7;
            Console.WriteLine("In Child Default Constructor");
        }

        //parameterized child constructor
        public Child(int id, string name, double height, string college) : base(id, name, height)
        {
            College = college;
        }


        public override string ToString()
        {
            string parentDetails = base.ToString();
            return $"{parentDetails}, College: {College}";
        }

    }
}

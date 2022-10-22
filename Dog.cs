using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Dog : Animal
    {
        string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Dog(string name)
            : base(name)
        { }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }

    }
}

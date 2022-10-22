﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Cat:Animal
    {
        string name;
       public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Cat(string name)
            : base(name)
        { }
      
      public override void Say()
        {
            Console.WriteLine("Мяу");
        }

    }
}

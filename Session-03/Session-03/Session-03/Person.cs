﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Person
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }



        public Person()
        {
            Id = Guid.NewGuid();
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}

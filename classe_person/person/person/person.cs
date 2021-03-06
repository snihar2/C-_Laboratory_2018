﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class Person
    {
        public String name;
        private DateTime birthday;

        public Person(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) ", name, birthday);
        }
    }
}

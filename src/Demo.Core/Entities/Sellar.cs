using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core
{
    public class Sellar
    {
        public Sellar()
        {

        }

        public Sellar(string name , string phone)
        {
            Name = name;
            Phone = phone;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}

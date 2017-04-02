using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core
{
    public class Dealer
    {
        public Dealer() { }

        public Dealer(string abn, string name)
        {
            Abn = abn;
            Name = name;
        }
        public string Name { get; set; }
        public string Abn { get; set; }
    }
}

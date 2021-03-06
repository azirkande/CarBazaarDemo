﻿using sDemo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public decimal Price { get; set; }
        public string Email { get; set; }
        public SellarType SellarType { get; set; }
        public Dealer Dealer { get; set; }
        public Sellar PrivateSellar { get; set; }
        public string Comments { get; set; }
        public string ImageFile { get; set; }
        public int Year { get; set; }

    }

    
}

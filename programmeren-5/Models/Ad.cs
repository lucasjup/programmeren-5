﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programmeren_5.Models
{
    public class Ad
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }
    }
}

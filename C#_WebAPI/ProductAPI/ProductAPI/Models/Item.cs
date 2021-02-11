﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class ProductItem
    {
        public long ID {get; set;}
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}

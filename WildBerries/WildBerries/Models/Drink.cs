﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WildBerries.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
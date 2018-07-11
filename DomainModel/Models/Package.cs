﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfSessions { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public int FreezeDuration { get; set; }
    }
}

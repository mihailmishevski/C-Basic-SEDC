﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public abstract int GetArea();

        public abstract int GetParameter();
    }
}

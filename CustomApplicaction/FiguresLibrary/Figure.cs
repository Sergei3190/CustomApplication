﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public abstract class Figure
    {
        public abstract string Name { get; }
        public abstract float Area();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Actor
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Actor(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

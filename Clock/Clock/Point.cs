﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Point
    {
        public int x;
        public int y;
        public string sign;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            Point o = obj as Point;
            if (this.x == o.x && this.y == o.y) return true;
            return false;
        }
    }
}
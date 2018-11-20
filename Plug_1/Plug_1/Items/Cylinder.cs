using Plug_1.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plug_1
{
    class Cylinder:Item
    {
        private readonly uint count = 0;
        private readonly string name = "Cylinder";
        public double Height { get; private set; }
        public double Radius { get; private set; }

        public Cylinder(double height, double radius)
        {
            Height = height;
            Radius = radius;
            count += 1;
            name += count;
        }

        public override string Print()
        {
            return name + " Height=" + Height + " Radius=" + Radius;
        }
    }
}

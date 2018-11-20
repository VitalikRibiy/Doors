using System;
using System.Collections.Generic;
using System.Text;
using Plug_1.Items;

namespace Plug_1
{
    class Sphere:Item
    {
        private readonly uint count = 0;
        private readonly string name = "Sphere";
        public Sphere(double radius)
        {
            Radius = radius;
            count += 1;
            name += count;
        }
        public double Radius { get; private set; }

        public override string Print()
        {
            return name + " Radius=" + Radius;   
        }
    }
}

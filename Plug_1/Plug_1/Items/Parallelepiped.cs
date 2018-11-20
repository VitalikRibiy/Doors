using System;
using System.Collections.Generic;
using System.Text;
using Plug_1.Items;

namespace Plug_1
{
    class Parallelepiped : Item
    {
        private readonly uint count = 0;
        private readonly string name = "Parallelepiped";
        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Length { get; private set; }
        public Parallelepiped(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
            count += 1;
            name += count;
        }

        public override string Print()
        {
            return name + " Height=" + Height + " Width=" + Width + " Length=" + Length;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Plug_1
{
    class Rectangle_Door:Door
    {
        private readonly uint count = 0;
        private readonly string name = "Rectangle_Door";
        public double Height { get; private set; }
        public double Length { get; private set; }

        public Rectangle_Door(double height, double length)
        {
            Height = height;
            Length = length;
            count += 1;
            name += count;
        }

        public override bool Fit(object item)
        {
            var a = item.GetType();
            switch (a.ToString())
            {
                default:
                    Console.WriteLine("Fit function error");
                    break;
                
                case "Plug_1.Parallelepiped":
                    var p = (Parallelepiped)item;
                    if ((p.Height <= Height && p.Length <= Length)|
                        (p.Height <= Height && p.Width <= Length)||
                        (p.Height <= Length && p.Length <= Height)||
                        (p.Height <= Length && p.Width <= Height)||
                        (p.Length <= Height && p.Width <= Length)||
                        (p.Length <= Length && p.Width <= Height))
                    {
                        return true;
                    }
                    else
                        return false;

                case "Plug_1.Sphere":
                    var s = (Sphere)item;
                    if (s.Radius * 2 <= Height && s.Radius * 2 <= Length)
                    {
                        return true;
                    }
                    return false;

                case "Plug_1.Cylinder":
                    var c = (Cylinder)item;
                    if ((c.Radius * 2 <= Height && c.Radius * 2 <= Length) ||
                        (c.Height <= Height && 2 * c.Radius <= Length) ||
                        (2 * c.Radius <= Height && c.Height <= Length))
                    {
                        return true;
                    }
                    return false;
            }
            return false;
        }

        public override string Print()
        {
            return name + " Height=" + Height + " Length=" + Length;
        }
    }
}
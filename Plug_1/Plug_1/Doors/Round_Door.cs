using System;
using System.Collections.Generic;
using System.Text;

namespace Plug_1
{
    class Round_Door:Door
    {
        private readonly uint count = 0;
        private readonly string name = "Round_Door";
        public double Radius { get; private set; }
        public Round_Door(double radius)
        {
            Radius = radius;
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
                    if ((Math.Sqrt(Math.Pow(p.Height, 2) + Math.Pow(p.Length, 2)) <= Radius * 2) ||
                        (Math.Sqrt(Math.Pow(p.Height, 2) + Math.Pow(p.Width, 2)) <= Radius * 2) ||
                        (Math.Sqrt(Math.Pow(p.Length, 2) + Math.Pow(p.Width, 2)) <= Radius * 2))
                    {
                        return true;
                    }
                    return false;
                
                case "Plug_1.Sphere":
                    var s = (Sphere)item;
                    if (s.Radius <= Radius)
                        return true;
                    return false;

                case "Plug_1.Cylinder":
                    var c = (Cylinder)item;
                    if (c.Radius <= Radius)
                        return true;
                    return false;
            }

            return false;
        }

        public override string Print()
        {
            return name + " Radius: " + Radius;
        }
    }
}

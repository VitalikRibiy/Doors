using System;
using System.Collections.Generic;
using Plug_1.Items;

namespace Plug_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Door> doors=new List<Door>();
            List<Item> items=new List<Item>();
            Menu(doors,items);
            Console.ReadKey();
        }

        static void Menu(List<Door> doors,List<Item> items)
        {
            Console.Clear();
            Console.WriteLine("1.Start\n2.Exit");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Start(doors, items);
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("You choosed unavailable option");
                    Console.ReadKey();
                    Menu(doors,items);
                    break;
            }
        }

        static void Start(List<Door> doors, List<Item> items)
        {
            Console.Clear();
            Console.WriteLine("1.Create door\n2.Create item\n3.Created Items\n4.Check");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    CreateDoor(doors, items);
                    break;

                case "2":
                    CreateItem(doors, items);
                    break;

                case "3":
                    Created_Objects(doors,items);
                    Start(doors, items);
                    break;

                case "4":
                    Check(doors, items);
                    break;
                
                default:
                    Console.WriteLine("You choosed unavailable option");
                    Console.ReadKey();
                    Start(doors, items);
                    break;
            }
        }

        static void CreateDoor(List<Door> doors, List<Item> items)
        {
            Console.Clear();
            Console.WriteLine("1.Create Rectangle Door\n2.Create Round Door\n3.Back");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.WriteLine("print height (with coma): ");
                    double h =Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("print length (with coma): ");
                    double l =Convert.ToDouble(Console.ReadLine());
                    Rectangle_Door temporary_door1 = new Rectangle_Door(h,l);
                    doors.Add(temporary_door1);
                    temporary_door1 = null;
                    Start(doors, items);
                    break;

                case "2":
                    Console.WriteLine("print radius (with coma): ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Round_Door temporary_door2 = new Round_Door(r);
                    temporary_door2 = null;
                    Start(doors, items);
                    break;

                case "3":
                    Start(doors,items);
                    break;

                default:
                    Console.WriteLine("You choosed unavailable option");
                    Console.ReadKey();
                    CreateDoor(doors,items);
                    break;
            }
        }
        
        static void CreateItem(List<Door> doors, List<Item> items)
        {
            Console.Clear();
            Console.WriteLine("1.Create Parallelepiped\n2.Create Sphere\n3.Create Cylinder\n4.Back");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("print height (with coma): ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("print length (with coma): ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("print width (with coma): ");
                    double w = Convert.ToDouble(Console.ReadLine());
                    Parallelepiped parallelepiped = new Parallelepiped(h, w, l);
                    items.Add(parallelepiped);
                    parallelepiped = null;
                    Start(doors, items);
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("print radius (with coma): ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Sphere sphere = new Sphere(r);
                    items.Add(sphere);
                    Start(doors, items);
                    break;
                    
                case "3":
                    Console.Clear();
                    Console.WriteLine("print radius (with coma): ");
                    double r1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("print height (with coma): ");
                    double h1 = Convert.ToDouble(Console.ReadLine());
                    Cylinder cylinder = new Cylinder(h1, r1);
                    items.Add(cylinder);
                    cylinder = null;
                    Start(doors, items);
                    break;

                case "4":
                    Start(doors, items);
                    break;

                default:
                    Console.WriteLine("You choosed unavailable option");
                    Console.ReadKey();
                    CreateDoor(doors, items);
                    break;
            }
        }           

        static void Created_Objects(List<Door> doors, List<Item> items)
        {
            uint count = 1;
            Console.WriteLine("Doors:");
            foreach (Door item in doors)
            {
                Console.WriteLine(count+"."+item.Print());
                count += 1;
            }
            count = 1;
            Console.WriteLine("Items:");
            foreach (Item item in items)
            {
                Console.WriteLine(count+"."+item.Print());
                count += 1;
            }
        }

        static void Check(List<Door> doors, List<Item> items)
        {
            Console.Clear();
            Created_Objects(doors,items);
            Console.WriteLine("Choose Door number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose Item number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(doors[num1 - 1].Fit(items[num2 - 1]));
            Console.ReadKey();
            Menu(doors, items);
        }
    }
}
using System;
using System.IO;
using System.Text;

namespace New_folder
{
    class Circle 
    {
        private int x;
        private int y;
        private int radius;
        private string color;
        public string drawCircle(int id)
        {
            string path = @"C:\Users\stili\VS_projects\C#\New folder\canvas.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            
            Console.WriteLine("Enter the x coordinate of the circle: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the circle: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the radius of the circle: ");
            radius = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Enter the color of the circle: ");
            color = Console.ReadLine();
            Console.ReadLine();
            
            string circle = "<circle id=\"" + id + "\" cx=\"" + x + "\" cy=\"" + y + "\" r=\"" + radius + "\" stroke=\"black\" stroke-width=\"3\" fill=\"" + color + "\"/>"+"\n";
            sr = sr.Insert(sr.Length - 6, circle);
            using var sw = File.CreateText(@"C:\Users\stili\VS_projects\C#\New folder\canvas.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
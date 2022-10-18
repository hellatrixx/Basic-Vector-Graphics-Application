using System;
using System.IO;
using System.Text;

namespace New_folder
{
    class Ellipse
    {
        private int x;
        private int y;
        private int radiusX;
        private int radiusY;
        private string color;
    
        public string drawEllipse(int id)
        {
            string path = @"C:\Users\stili\VS projects\C#\New folder\test.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            
            Console.WriteLine("Enter the x coordinate of the ellipse: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the ellipse: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the radiusX of the ellipse: ");
            radiusX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the radiusY of the ellipse: ");
            radiusY = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Enter the color of the ellipse: ");
            color = Console.ReadLine();
            Console.ReadLine();
            
            string ellipse = "<ellipse id=\"" + id + "\" cx=\"" + x + "\" cy=\"" + y + "\" rx=\"" + radiusX + "\" ry=\"" + radiusY + "\" stroke=\"black\" stroke-width=\"3\" fill=\"" + color + "\"/>"+"\n";
            sr = sr.Insert(sr.Length - 6, ellipse);
            using var sw = File.CreateText(@"C:\Users\stili\VS projects\C#\New folder\test.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
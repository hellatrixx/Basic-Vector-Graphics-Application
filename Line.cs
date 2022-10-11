using System;
using System.IO;
using System.Text;

namespace New_folder
{
    class Line
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private string color;
        public string drawLine()
        {
            string path = @"C:\Users\stili\VS projects\C#\New folder\test.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            
            Console.WriteLine("Enter the x coordinate of the first point: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the first point: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x coordinate of the second point: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the second point: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the color of the line: ");
            color = Console.ReadLine();
            Console.ReadLine();
            
            string line = "<line x1=\"" + x1 + "\" y1=\"" + y1 + "\" x2=\"" + x2 + "\" y2=\"" + y2 + "\" stroke=\"" + color + "\" stroke-width=\"3\"/>";
            sr = sr.Insert(sr.Length - 6, line);
            using var sw = File.CreateText(@"C:\Users\stili\VS projects\C#\New folder\test.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
using System;
using System.IO;
using System.Text;

namespace New_folder
{
    class Polyline
    {
        private int x;
        private int y;
        private int x1;
        private int y1;
        private string color;
        
        public string drawPolyline(int id)
        {
            string path = @"C:\Users\stili\VS projects\C#\New folder\test.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            
            Console.WriteLine("Enter the x coordinate of the first point: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the first point: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x coordinate of the second point: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the second point: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Enter the color of the polyline: ");
            color = Console.ReadLine();
            Console.ReadLine();
            
            string polyline = "<polyline id=\"" + id + "\" points=\"" + x + "," + y + " " + x1 + "," + y1 + "\" style=\"fill:none;stroke:" + color + ";stroke-width:3\"/>"+"\n";
            sr = sr.Insert(sr.Length - 6, polyline);
            using var sw = File.CreateText(@"C:\Users\stili\VS projects\C#\New folder\test.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
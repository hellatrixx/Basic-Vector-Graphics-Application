using System;
using System.IO;
using System.Text;

namespace New_folder
{
    class Path
    {
        private int x;
        private int y;
        private int x1;
        private int y1;
        private string color;
        public static int id;
        public string drawPath(int id)
        {
            string path = @"C:\Users\stili\VS_projects\C#\New folder\canvas.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            
            Console.WriteLine("Enter the x coordinate of the path: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the path: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x1 coordinate of the path: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y1 coordinate of the path: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Enter the color of the path: ");
            color = Console.ReadLine();
            Console.ReadLine();
            
            string path1 = "<path id=\"" + id + "\" d=\"M " + x + " " + y + " L " + x1 + " " + y1 + "\" stroke=\"" + color + "\" stroke-width=\"3\" fill=\"none\"/>"+"\n";
            sr = sr.Insert(sr.Length - 6, path1);
            using var sw = File.CreateText(@"C:\Users\stili\VS_projects\C#\New folder\canvas.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
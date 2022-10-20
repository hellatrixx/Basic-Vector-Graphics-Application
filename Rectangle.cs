using System;
using System.IO;
using System.Text;

namespace New_folder
{
    class Rectangle
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private string color;
        
        public string drawRectangle(int id)
        {
            string path = @"C:\Users\stili\VS_projects\C#\New folder\canvas.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            
            Console.WriteLine("Enter the x coordinate of the rectangle: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the rectangle: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle: ");
            height = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Enter the color of the rectangle: ");
            color = Console.ReadLine();
            Console.ReadLine();
            
            string rectangle = "<rect id=\"" + id + "\" x=\"" + x + "\" y=\"" + y + "\" width=\"" + width + "\" height=\"" + height + "\" stroke=\"black\" stroke-width=\"3\" fill=\"" + color + "\"/>"+"\n";
            sr = sr.Insert(sr.Length - 6, rectangle);
            using var sw = File.CreateText(@"C:\Users\stili\VS_projects\C#\New folder\canvas.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
using System;
using System.IO;
using System.Text;

namespace New_folder
{
    class Polygon
    {
        public string drawPolygon()
        {
            string path = @"C:\Users\stili\VS_projects\C#\New folder\canvas.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            Console.WriteLine("Enter the number of points: ");
            int points = Convert.ToInt32(Console.ReadLine());
            string[] x = new string[points];
            string[] y = new string[points];
            for(int i = 0; i < points; i++)
            {
                Console.WriteLine("Enter the x coordinate of point " + (i + 1) + ": ");
                x[i] = Console.ReadLine();
                Console.WriteLine("Enter the y coordinate of point " + (i + 1) + ": ");
                y[i] = Console.ReadLine();
            }
            string polygon = "<polygon points=\"";
            for(int i = 0; i < points; i++)
            {
                polygon += x[i] + "," + y[i] + " ";
            }
            polygon += "\" style=\"fill:lime;stroke:purple;stroke-width:1\" />"+"\n";
            sr = sr.Insert(sr.Length - 6, polygon);
            using var sw = File.CreateText(@"C:\Users\stili\VS_projects\C#\New folder\canvas.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
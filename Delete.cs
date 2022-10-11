using System;
using System.IO;
using System.Text;

namespace New_folder
{
    class Delete
    {
        public string delete(Ellipse ellipse)
        {
            string path = @"C:\Users\stili\VS projects\C#\New folder\test.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            sr = sr.Remove(sr.Length - 6, ellipse.drawEllipse().Length);
            using var sw = File.CreateText(@"C:\Users\stili\VS projects\C#\New folder\test.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
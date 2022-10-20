using System;
using System.IO;
using System.Text;

namespace New_folder
{
    public class Delete
    {
        public string delete(int id)
        {
            string path = @"C:\Users\stili\VS_projects\C#\New folder\canvas.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            foreach (string line in File.ReadLines(path))
            {
                if (line.Contains("id=\""+ id + "\""))
                {
                    sr = sr.Replace(line, "").TrimEnd();
                }
            }
            using var sw = File.CreateText(@"C:\Users\stili\VS_projects\C#\New folder\canvas.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
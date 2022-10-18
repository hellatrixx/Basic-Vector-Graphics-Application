using System;
using System.IO;
using System.Text;

namespace New_folder
{
    public class Delete
    {
        public string delete(string id)
        {
            string path = @"C:\Users\stili\VS projects\C#\New folder\test.svg";
            string sr = File.ReadAllText(path , Encoding.UTF8);
            foreach (string line in File.ReadLines(path))
            {
                if (line.Contains("id=\""+ id + "\""))
                {
                    sr = sr.Replace(line, "").Replace(line, "").TrimEnd();
                    sr.Remove(0, line.Length);
                }
            }
            sr = sr.Remove(Circle.id, 1);
            using var sw = File.CreateText(@"C:\Users\stili\VS projects\C#\New folder\test.svg");
            sw.Write(sr);
            return sr;
        }
    }
}
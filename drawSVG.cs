using System;
using System.IO;

namespace New_folder
{
    class drawSVG
    {
        private int width = 400;
        private int height = 400;
        public string draw()
        {
            string svg = "<svg width=\"" + width + "\" height=\"" + height + "\" xmlns=\"http://www.w3.org/2000/svg\">\n</svg>";
            using var sw = File.CreateText(@"C:\Users\stili\VS projects\C#\New folder\test.svg");
            sw.Write(svg);
            return svg;
        }
    }
}
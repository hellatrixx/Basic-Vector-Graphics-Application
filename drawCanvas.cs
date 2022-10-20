using System;
using System.IO;

namespace New_folder
{
    class drawCanvas
    {
        private int width = 400;
        private int height = 400;
        public string draw()
        {
            string svg = "<svg width=\"" + width + "\" height=\"" + height + "\" xmlns=\"http://www.w3.org/2000/svg\">\n</svg>";
            using var sw = File.CreateText(@"C:\Users\stili\VS_projects\C#\New folder\canvas.svg");
            sw.Write(svg);
            return svg;
        }
    }
}
using System;

namespace New_folder
{
    class Interface
    {
        drawSVG draw = new drawSVG();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Polygon polygon = new Polygon();
        Ellipse ellipse = new Ellipse();
        Polyline polyline = new Polyline();
        Path path = new Path();
        Line line = new Line();
        public Interface()
        {
            Console.WriteLine("              CS264 Assignment 2\n                Stilian Kolev\n============================================");
            Console.WriteLine("\n1: Create a canvas.\n2: Draw a Circle.\n3: Draw a Rectangle.\n4: Draw a Polygon.\n5: Draw an Ellipse. \n6: Draw a Polyline. \n7: Draw a Path. \n8: Draw a Line. \n9: Delete. \n10: Exit.");
            string userInput = Console.ReadLine();
            while(userInput != "5")
            {
                if(userInput == "1")
                {
                    Console.WriteLine(draw.draw());
                    userInput = Console.ReadLine();
                    
                }
                if(userInput == "2")
                {
                    Console.WriteLine(circle.drawCircle());
                    userInput = Console.ReadLine();
                }
                if(userInput == "3")
                {
                    Console.WriteLine(rectangle.drawRectangle());
                    userInput = Console.ReadLine();
                }
                if(userInput == "4")
                {
                    Console.WriteLine(polygon.drawPolygon());
                    userInput = Console.ReadLine();
                }
                if(userInput == "5")
                {
                    Console.WriteLine(ellipse.drawEllipse());
                    userInput = Console.ReadLine();
                } 
                if(userInput == "6")
                {
                    Console.WriteLine(polyline.drawPolyline());
                    userInput = Console.ReadLine();
                }
                if(userInput == "7")
                {
                    Console.WriteLine(path.drawPath());
                    userInput = Console.ReadLine();
                }
                if(userInput == "8")
                {
                    Console.WriteLine(line.drawLine());
                    userInput = Console.ReadLine();
                }
                if(userInput == "9")
                {
                    Delete delete = new Delete();
                    Console.WriteLine(delete.delete(ellipse));
                    userInput = Console.ReadLine();
                }
                if(userInput == "10")
                {
                    break;
                }
            }
        }

        public static void Main(string[] args)
        {
            Interface interface1 = new Interface();
        }

        

    }
}
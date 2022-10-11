using System;

namespace New_folder
{
    class Interface
    {
        public Interface()
        {
            Console.WriteLine("              CS264 Assignment 2\n                Stilian Kolev\n============================================");
            Console.WriteLine("\n1: Create a canvas.\n2: Draw a Circle.\n3: Draw a Rectangle.\n4: Draw a Polygon.\n5: Draw an Ellipse. \n6: Draw a Polyline. \n7: Draw a Path. \n8: Draw a Line. \n9: Exit.");
            string userInput = Console.ReadLine();
            while(userInput != "5")
            {
                if(userInput == "1")
                {
                    drawSVG draw = new drawSVG();
                    Console.WriteLine(draw.draw());
                    userInput = Console.ReadLine();
                    
                }
                if(userInput == "2")
                {
                    Circle circle = new Circle();
                    Console.WriteLine(circle.drawCircle());
                    userInput = Console.ReadLine();
                }
                if(userInput == "3")
                {
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine(rectangle.drawRectangle());
                    userInput = Console.ReadLine();
                }
                if(userInput == "4")
                {
                    Polygon polygon = new Polygon();
                    Console.WriteLine(polygon.drawPolygon());
                    userInput = Console.ReadLine();
                }
                if(userInput == "5")
                {
                    Ellipse ellipse = new Ellipse();
                    Console.WriteLine(ellipse.drawEllipse());
                    userInput = Console.ReadLine();
                } 
                if(userInput == "6")
                {
                    Polyline polyline = new Polyline();
                    Console.WriteLine(polyline.drawPolyline());
                    userInput = Console.ReadLine();
                }
                if(userInput == "7")
                {
                    Path path = new Path();
                    Console.WriteLine(path.drawPath());
                    userInput = Console.ReadLine();
                }
                if(userInput == "8")
                {
                    Line line = new Line();
                    Console.WriteLine(line.drawLine());
                    userInput = Console.ReadLine();
                }
                if(userInput == "9")
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
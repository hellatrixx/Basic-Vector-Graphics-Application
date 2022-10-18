using System;

namespace New_folder
{
    class Interface
    {
        drawCanvas draw = new drawCanvas();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Polygon polygon = new Polygon();
        Ellipse ellipse = new Ellipse();
        Polyline polyline = new Polyline();
        Path path = new Path();
        Line line = new Line();
        public static int id;
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
                    id++;
                    Console.WriteLine(circle.drawCircle(id));
                    userInput = Console.ReadLine();             
                    }
                if(userInput == "3")
                {
                    id++;
                    Console.WriteLine(rectangle.drawRectangle(id));
                    userInput = Console.ReadLine();
                }
                if(userInput == "4")
                {
                    id++;
                    Console.WriteLine(polygon.drawPolygon());
                    userInput = Console.ReadLine();
                }
                if(userInput == "5")
                {
                    id++;
                    Console.WriteLine(ellipse.drawEllipse(id));
                    userInput = Console.ReadLine();
                } 
                if(userInput == "6")
                {
                    id++;
                    Console.WriteLine(polyline.drawPolyline(id));
                    userInput = Console.ReadLine();
                }
                if(userInput == "7")
                {
                    id++;
                    Console.WriteLine(path.drawPath(id));
                    userInput = Console.ReadLine();
                }
                if(userInput == "8")
                {
                    id++;
                    Console.WriteLine(line.drawLine(id));
                    userInput = Console.ReadLine();
                }
                if(userInput == "9")
                {
                    Console.WriteLine("Please provide the ID of the shape you want to delete:");
                    id = int.Parse(Console.ReadLine());
                    Delete delete = new Delete();
                    Console.WriteLine(delete.delete(id));
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
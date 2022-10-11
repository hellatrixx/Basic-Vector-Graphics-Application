using System;

namespace New_folder
{
    class Interface
    {
        public Interface()
        {
            Console.WriteLine("              CS264 Assignment 2\n                Stilian Kolev\n============================================");
            Console.WriteLine("\n1: Create a canvas.\n2: Draw a Circle.\n3: Draw a Rectangle.\n4: Draw a Polygon.\n5: Exit.");
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
                if(userInput == "5")
                {
                    break;
                }
            }
        }

        

    }
}
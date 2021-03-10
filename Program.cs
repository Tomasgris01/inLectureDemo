using System;

namespace inLectureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle box; // declare variable of type rectangle
            box = new Rectangle(); // recreating an object of type rectangle
            box.length = 10;
            box.width = 30;
            int area = box.calArea();
            Console.WriteLine("The area of box 1 is {0}",area);
            Console.WriteLine(box.ToString());



            Rectangle box2;
            box2 = new Rectangle();

            box2.length = 6;
            box2.width = 8;
             area = box2.calArea();
            Console.WriteLine("The area of box 2 is {0}", area);


            Rectangle box3;
            box3 = new Rectangle(5,10);

            
            area = box3.calArea();
            Console.WriteLine("The area of box 2 is {0}", area);
        }
    }
}

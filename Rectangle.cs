using System;
using System.Collections.Generic;
using System.Text;

namespace inLectureDemo
{
    class Rectangle
    {
        //attributes of the class
        public int length;
        public int width;

        //Methods
        //constructor method - must call this before we can use the class

        public Rectangle()
        {

        }

        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }

        public int calArea()
        {
            return length * width;
        }
       
        
        public virtual string ToString () // special method that tells us about the object
         {

            return "I am a rectangle with lenght  " + length;

         }

    }
}

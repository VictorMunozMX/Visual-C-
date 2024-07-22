using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Rectangle4
{
    class Rectangle
    {
        // variables
        private float height;
        private float width;
        private float area;
        private float perimeter;
        private bool square;
        // constructors
        public Rectangle() 
        {
        }
        public Rectangle(float h, float w)
        {
            height = h;
            width = w;
        }
        // accessor and mutators
        public float Height {
            get { return height; }
            set { height = value; }
        }
        public float GetWidth() { 
            return width;
        }
        /*public void SetHeight(float h)
        {
            height = h;
        }*/
        public void SetWidth(float w)
        {
            width = w;
        }
        // Methods
        // calculate area
        public float ComputeArea() { 
            area = height * width;
            return area;
        }
        // calculate perimeter
        public float ComputePerimeter()
        {
            perimeter = 2*(height + width);
            return perimeter;
        }
        // valid isSquare
        public bool isSquare() {
            square = false;
            if (height == width)
            {
                square = true;
            }            
            return square;
        }
        // display on screen
        public override string ToString() {
            return "\nHeight:     " + height + 
                   "\nWidth:      " + width + 
                   "\n\nArea:     " + area + 
                   "\nPerimeter: " + perimeter + 
                   "\n\nFinally, the result of comparison of weidth and height is: " + "\" " + square + "\"";
        }
    }
}

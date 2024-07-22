using System;
using static System.Console;

namespace WarehouseApp
{
    class Box
    {
        private float height;
        private float width;
        private float depth;

        public Box()
        {
        }

        public Box(float h, float w, float d)
        {
            height = h;
            width = w;
            depth = d;
        }
        public float H
        {
            get { return height; }
            set { height = value; }            
        }
        public float W
        {
            get { return width; }   
            set { width = value; }
        }
        public float D
        { 
            get { return depth; }
            set { depth = value; }
        }

        public float Volume()
        {
            return height * width * depth;
        }

        public override string ToString()
        {
            return "Height: " + height + "\nWidth: " + width + "\nDepth:" + depth + "\n  Volume: " + Volume();
        }
    }
}

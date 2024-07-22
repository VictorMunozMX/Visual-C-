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

        public float Volume()
        {
            return height * width * depth;
        }

        public override string ToString()
        {
            return "Height: " + height + ", width: " + width + ", depth:" + depth + ". Volume: " + Volume();
        }
    }
}

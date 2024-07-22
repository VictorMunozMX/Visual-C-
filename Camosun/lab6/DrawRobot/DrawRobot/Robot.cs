using System;
using System.Linq.Expressions;
using System.Security.Policy;
using static System.Console;

namespace DrawRobot
{
    class Robot
    {
        private string symbol;

        // default constructor
        public Robot()
        {
        }
        public Robot(string s)
        {
            symbol = s;
        }
        // mut
        public string Symbol
        {
            set {symbol = value;} 
        }
        // Methods
        public void Draw()
        {
            DrawHead();
        }
        private void DrawHead()
        {
            const int MAX_HEIGHT = 9, MAX_WIDTH = 9;
            
            WriteLine();
            for (int i = 0; i < MAX_HEIGHT; i++)
            {
                for (int j = 0; j < MAX_WIDTH; j++)
                {
                    if (i == 0 || j == 0 || i == MAX_HEIGHT - 1 || j == MAX_WIDTH - 1)
                    {
                        Write("{0}",symbol);
                    }
                    else
                    {
                        if (i == 3 && (j == 3 || j == 5)) // or whatever you want
                        {
                            Write("@");
                        }
                        else
                        {
                            if (i==5 && (j>2 && j<6)) // or whatever you want
                            {
                                Write("=");
                            }
                            else
                            {
                                if (i == 4 && (j == 4)) // or whatever you want
                                {
                                    Write("+");
                                }
                                else
                                {
                                    Write(" ");
                                }
                            }                                
                        }                        
                    }
                }
                WriteLine();
            }            
        }
    }
}

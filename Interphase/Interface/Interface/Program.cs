// A simple interface
using System;

interface IInter1
{
    // method having only declaration
    // not definition
    void display();
}
// A class that implements interface.
class testClass : IInter1
{
    // providing the body part of function
    public void display()
    {
        Console.WriteLine("This Interface is working!");
    }
    // Main Method
    public static void Main(String[] args)
    {
        // Creating object
        testClass t = new testClass();
        // calling method
        t.display();
        Console.ReadKey();
    }
}
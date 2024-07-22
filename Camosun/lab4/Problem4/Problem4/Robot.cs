using System;
using static System.Console;

namespace Problem4
{
    class Robot
    {
        // Declare the member variables for the robot class
        private string robotName, robotId, robotGreeting;
        private int batteryCharge;

        public Robot()
        {
        }
        public Robot(string paramId, string paramName, string paramGreeting)
        {
            robotId = paramId;
            robotName = paramName;
            robotGreeting = paramGreeting;
        }
        
        // Define the accessors and mutators
        public int GetBatteryCharge()
        {
            return batteryCharge;
        }
        public void SetBatteryCharge(int chargePoints)
        {
            batteryCharge = chargePoints;
        }

        // Define the instance methods
        public void ChargeBaterry(int chargePoints)
        {
            batteryCharge += chargePoints;
        }
        public void DrainBattery(int chargePoints)
        {
            batteryCharge -= chargePoints;
        }      
        public override string ToString()
        {
            return "Robot ID: " + robotId + ", Name: " + robotName + ", greeting: \"" + robotGreeting + "\", battery: " + batteryCharge;        
        }
    }
}

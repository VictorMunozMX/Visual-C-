using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Adventurer
{
    class Adventur
    {
        private string fullName;
        private int healthPoints;
        private bool honest;
        private float weight;
        private decimal salary;

        public Adventur()
        {
        }
        public Adventur(string n, int p, bool h, float w, decimal s) 
        {
            fullName = n;
            healthPoints = p;
            honest = h;
            weight = w;
            salary = s;
        }
        public string GetFullName()
        {
            return fullName;
        }
        public int GetHealtPoints()
        {
            return healthPoints;
        }
        public bool GetHonest()
        {
            return honest;
        }
        public float GetWeight()
        { 
            return weight; 
        }
        public decimal GetDecimal() 
        {
            return salary;
        }
        public void SetFullName(string name)
        {
            fullName = name;
        }
        public void SetHealthPoints(int health)
        {
            healthPoints = health;
        }
        public void SetHonest(bool h)
        {
            honest = h;
        }
        public void SetWeight(float w)
        {
            weight = w;
        }
        public void SetSalary(decimal d)
        {
            salary = d;
        }
        public override string ToString()
        {
            return "\nYour name is: " + fullName + ", your health points is: " + healthPoints +
                "\nYou are honest: " + honest + ", your weight is: " + weight + 
                "\nFinally, your salary is aorund: " + salary;
        }
    }
}

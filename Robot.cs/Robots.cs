using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Robot.cs
{
    public abstract class Robots
    {
        public int batteryLevel = 100;
        public int damage = 100;
        public string weapon;
        
        public Robots()
        {

        }

        public void DisplayCountDown()
        {
            getBatteryLevel();
            for (int i = 10; i >= 0; --i)
            {
                Console.Write("Time: {0}", i);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        public void getBatteryLevel()
        {
            Console.WriteLine("Alert! Battery Below 25%! You must Wait 10 seconds for me to charge up. Press enter to start timer.");
            Console.ReadLine();
        }
        
        public abstract int UseSpecialMove();
        public void getDamage()
        {
            if (damage <= 0)
            {
                Console.WriteLine("Game Over! You Lose! Press Any Key To Leave Game.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public abstract int getWeapon();
    }
}



        
    


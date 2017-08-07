using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace Robot.cs
{
    public class Battleground
    {


        public Battleground()
        {

        }

        public string WelcomeRoboWarriors;

        public void DisplayCountDown()
        {
            for (int i = 2; i >= 0; --i)
            {
                Console.Write("Time: {0}", i);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        public void Welcome()
        {
            Console.WriteLine("WELCOME! Prepare For Battle! Press Any Key to Continue.");
            WelcomeRoboWarriors = Console.ReadLine();

        }
        public void run()
        {
            MyRobot robot1 = new MyRobot();
            YourRobot robot2 = new YourRobot();
            List<string> robots = new List<string>();
            robots.Add("MyRobot");
            robots.Add("YourRobot");
            robot1.TakeDamage(robot2.UseSpecialMove());
            DisplayCountDown();
            robot2.TakeDamage(robot1.UseSpecialMove());
            DisplayCountDown();
            robot1.TakeDamage(robot2.getWeapon());
            robot1.DisplayCountDown();
            robot2.TakeDamage(robot1.getWeapon());
            DisplayCountDown();
            robot1.TakeDamage(robot2.UseSpecialMove());
            DisplayCountDown();
            robot2.TakeDamage(robot1.UseSpecialMove());
            robot2.DisplayCountDown();
            robot1.TakeDamage(robot2.getWeapon());
            DisplayCountDown();
            robot2.TakeDamage(robot1.getWeapon());
        }
    }   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.cs
{
    public class Battleground 
    {
        
        public Battleground()
        {

        }
        public void run()
        {
            MyRobot robot1 = new MyRobot();
            YourRobot robot2 = new YourRobot();
            List<string> robots = new List<string>();
            robots.Add("MyRobot");
            robots.Add("YourRobot");
            robot1.TakeDamage(robot2.UseSpecialMove());
            robot2.TakeDamage(robot1.UseSpecialMove());
            robot1.TakeDamage(robot2.getWeapon());
            robot2.TakeDamage(robot1.getWeapon());
            robot1.TakeDamage(robot2.UseSpecialMove());
            robot2.TakeDamage(robot1.UseSpecialMove());
            robot1.TakeDamage(robot2.getWeapon());
            robot2.TakeDamage(robot1.getWeapon());
            
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void getBatteryLevel()
        {
            
            
            if (batteryLevel < 25)
            {
                Console.WriteLine("Alert! Battery Below 25%! I Need To Be Charged!");
                Console.ReadLine();
            }
        }
        public abstract int UseSpecialMove();
        public void getDamage()
        {
            if (damage <= 0)
            {
                Console.WriteLine("Game Over! You Lose!");
                Console.ReadLine();
                
            }

        }

        public abstract int getWeapon();
    }
}



        
    


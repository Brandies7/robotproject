using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.cs
{
    public class YourRobot : Robots
    {
        public string MyMove;
       
        public override int UseSpecialMove()
        {
            Console.WriteLine("Player 1, Do you want to use Flying Elbows (Deducts 20 points from opponent)? 'yes' or 'no' (No=BackHand)");
            MyMove = Console.ReadLine();
            if (MyMove == "yes")
            {
                return 20;
            }
            else if (MyMove == "no")
            {
                Console.WriteLine("Then I must backhand him!");
                Console.ReadLine();
                return 10;
            }
            else
            {
                Console.WriteLine("Not a valid Entry! Please Try Again");
                UseSpecialMove();
            }
            return 0;
        }
           
        
        public void TakeDamage(int amount)
        {
            damage -= amount;
            if (damage <= 0)
            {
                Console.WriteLine("Player 1, Better Luck Next Time");
                getDamage();
            }
        }
        public override int getWeapon()
        {
            Console.WriteLine("Player 1: Choose Your Weapon to Use. Select '1' for Laser Eyes (deducts 30 points from opponent), Select '2' for Jericho Missiles (deducts 50 points from opponent)");
            string useWeapon = Console.ReadLine();

            switch (useWeapon)
            {
                case "1":
                    
                    return 30;

                case "2":
                    
                    return 50;

                default:
                    Console.WriteLine("You must choose one or suffer the consequences");
                    getWeapon();
                    return 0;
            }
        }
    }
}

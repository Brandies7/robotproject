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
            Console.WriteLine("Player 1, Do you want to use Flying Elbows? 'yes' or 'no'");
            MyMove = Console.ReadLine();
            if (MyMove == "yes")
            {
                return 20;
            }
            return 0;
            
            
        }
        public void TakeDamage(int amount)
        {
            damage -= amount;
            if (damage <= 0)
            {
                getDamage();
            }
        }
        public override int getWeapon()
        {
            Console.WriteLine("Player 1: Choose Your Weapon to Use. Select '1' for Laser Eyes, Select '2' for Jericho Missiles");
            string useWeapon = Console.ReadLine();

            switch (useWeapon)
            {
                case "1":
                    
                    return 30;

                case "2":
                    
                    return 50;

                default:
                    Console.WriteLine("You must choose one or suffer the consequences");
                    Console.ReadLine();
                    return 0;
            }

        }
    }
}

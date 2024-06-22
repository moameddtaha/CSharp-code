using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Game
    {
        public void Battle(Character c1, Character c2)
        {
            Console.WriteLine($"--- Battle between {c1.Name} and {c2.Name} ---");
            while(c1.Health > 0 && c2.Health > 0)
            {
                c1.AbilityAttack(c2);
                if(c2.Health > 0)
                {
                    c2.Defend();
                    c2.AbilityAttack(c1);
                }
                c1.Defend();
            }

            if(c1.Health <= 0)
            {
                System.Console.WriteLine($"{c2.Name} wins!");
            }
            else if(c2.Health <= 0)
            {
                System.Console.WriteLine($"{c1.Name} wins!");
            }
        }
    }
}

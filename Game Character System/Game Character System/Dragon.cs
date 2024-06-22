using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game
{
    public class Dragon : Character
    {
        public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense)
        {
            // No additional code required.
        }

        public override void AbilityAttack(Character target)
        {
            int damage = this.Attack * 4 - target.Defense;
            if (this.Attack > 0)
            {
                target.Health -= damage;
                System.Console.WriteLine($"{this.Name} breathes fire on {target.Name} for {damage} damage!");
            }
            else if (this.Attack <= 0)
            {
                System.Console.WriteLine($"{this.Name}'s fire has no effect on {target.Name}.");
            }
        }
        public override void Defend()
        {
            this.Defense += 10;
            Console.WriteLine($"{this.Name} defends and gains 10 defense.");
        }
    }
}

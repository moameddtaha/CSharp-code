using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Warrior : Character
    {
        
        public Warrior(string name, int health, int attack, int defense) : base(name, health, attack, defense)
        {
            // No additional code required.
        }

        // Charge
        public override void AbilityAttack(Character target)
        {
            int damage = this.Attack * 2 - target.Defense;
            if (this.Attack > 0)
            {
                target.Health -= damage;
                System.Console.WriteLine($"{this.Name} charges {target.Name} for {damage} damage!");
            }
            else if (this.Attack <= 0)
            {
                System.Console.WriteLine($"{this.Name}'s attack has no effect on {target.Name}.");
            }
        }
        public override void Defend()
        {
            this.Defense += 5;
            Console.WriteLine($"{this.Name} defends and gains 5 defense.");
        }

    }
}

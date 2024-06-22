using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Mage : Character
    {

        public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
        {
            // No additional code required.
        }

        public override void AbilityAttack(Character target)
        {
            int damage = this.Attack * 3 - target.Defense;
            if (this.Attack > 0)
            {
                target.Health -= damage;
                System.Console.WriteLine($"{this.Name} casts a spell on {target.Name} for {damage} damage!");
            }
            else if (this.Attack <= 0)
            {
                System.Console.WriteLine($"{this.Name}'s spell has no effect on {target.Name}.");
            }
        }
        public override void Defend()
        {
            Console.WriteLine($"{this.Name} cannot defend!");
        }
    }
}

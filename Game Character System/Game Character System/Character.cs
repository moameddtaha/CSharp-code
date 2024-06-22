using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Character
    {
        private string? _name;
        private int _health;
        private int _attack;
        private int _defense;

        public Character()
        {
            this._name = null;
            this._health = 0;
            this._attack = 0;
            this._defense = 0;
        }
        protected Character(string name, int health, int attack, int defense)
        {
            this._name = name;
            this._health = health;
            this._attack = attack;
            this._defense = defense;
        }
        public abstract void AbilityAttack(Character target);
        public abstract void Defend();

        public string? Name { 
            set { _name = value; }
            get {return _name; }
        }
        public int Health {
            set { _health = value; }
            get { return _health; }
        }
        public int Attack {
            set { _attack = value; }
            get { return _attack; }
        }
        public int Defense {
            set { _defense = value; }
            get { return _defense; }
        }
    }

}

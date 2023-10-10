using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Pokemon
    {
        public string name;
        public int hp;
        public int damage;
        public string element;

        public Pokemon() //Default
        {
            
        }

        public Pokemon(string name, int hp, int damage, string element)  //Constructor
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
            this.element = element;
        }

        public int Attack(Pokemon challenger, Pokemon opponent)
        {
            opponent.hp = opponent.hp - challenger.damage;

            return opponent.hp;
        }

        public int CounterAttack(Pokemon challenger, Pokemon opponent)
        {
            challenger.hp = challenger.hp - opponent.damage;

            return challenger.hp;
        }
    }
}

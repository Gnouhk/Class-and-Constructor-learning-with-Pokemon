using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Pikachu pok1 = new Pikachu();
            Console.WriteLine(pok1.name + " hp:" + pok1.hp + " atk:" + pok1.damage);

            Charmander pok2 = new Charmander();
            Console.WriteLine(pok2.name + " hp:" + pok2.hp + " atk:" + pok2.damage);

            pok1.Attack(pok1, pok2);
            Console.WriteLine("=======================================");
            Console.WriteLine(pok1.name + " attack!!");
            Console.WriteLine(pok2.name + " has " + pok2.hp + "hp left");

            if (pok2.hp <= 0)
            {
                Console.WriteLine(pok2.name + " is defeated");
                Console.WriteLine(pok1.name + " is the winner!");
            }
            else
            {
                Console.WriteLine(pok2.name + " still alive!!");
                pok2.CounterAttack(pok1, pok2);
                Console.WriteLine("=======================================");
                Console.WriteLine(pok2.name + " counter attack!!");
                Console.WriteLine("It's super effective!!");
                Console.WriteLine(pok1.name + " has " + pok1.hp + "hp left");

                if(pok1.hp <= 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine(pok1.name + " is defeated");
                    Console.WriteLine(pok2.name + " is the winner!");
                }
            }
        }
    }
}

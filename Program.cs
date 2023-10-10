using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pok1 = new Pokemon("Pikachu",4,3);
            Console.WriteLine(pok1.name + " hp:" + pok1.hp + " atk:" + pok1.damage);

            Pokemon pok2 = new Pokemon("Charmander",4,4);
            Console.WriteLine(pok2.name + " hp:" + pok2.hp + " atk:" + pok2.damage);

            pok1.Attack(pok1, pok2);
            Console.WriteLine("=======================================");
            Console.WriteLine(pok1.name + " attack!!");
            Console.WriteLine(pok2.name + " have " + pok2.hp + "hp left");

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
                Console.WriteLine(pok1.name + " have " + pok1.hp + "hp left");

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

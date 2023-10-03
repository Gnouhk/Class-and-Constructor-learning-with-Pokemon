using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pok1 = new Pokemon("Pikachu",2,3);
            Console.WriteLine(pok1.name + " hp:" + pok1.hp + " atk:" + pok1.damage);
        }
    }
}

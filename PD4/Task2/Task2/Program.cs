using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player alice = new Player("Alice", 110, 50, 10);
            Player bob = new Player("Bob", 100, 60, 20);
            Stats fireball = new Stats("fireball", 23, 1.2, 5, 15, "a firey magical attack");
            Stats superbeam = new Stats("superbeam", 200, 50, 50, 75, "an overpowered attack, pls nerf");
            alice.LearnSkill(fireball);
            bob.LearnSkill(superbeam);
            Console.WriteLine(alice.Attack(bob));
            Console.WriteLine(bob.Attack(alice));
            Console.ReadKey();
        }
    }
}

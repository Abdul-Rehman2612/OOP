using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiritori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("1 -> Play Game");
                Console.WriteLine("2 -> Restart");    
            Console.WriteLine("3 -> Exit Game");
            Console.Write("Enter option: ");
            string option=Console.ReadLine();
            my_shiritori Game =new my_shiritori();
            if (option == "1") {

                while (true)
                {
                Console.Clear();
                    Console.Write("Enter word: ");
                    string word= Console.ReadLine();
                    List<string> result=Game.play(word);
                    if (result[0]=="Game Over")
                    {
                        Console.WriteLine("Game Over");

                        break;
                    }
                    else 
                    {
                        continue;
                    }
                }
            }
            else if (option == "2")
                {
                    Console.WriteLine(Game.restart());
                }
            else if (option == "3")
            {
                return;
            }
            }
        }
    }
}

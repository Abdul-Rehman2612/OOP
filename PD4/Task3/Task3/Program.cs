using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            List<Stats> skills = new List<Stats>();
            while(true)
            {
                Console.Clear();
                string option = Menu();
                if(option == "1")
                {
                    Console.Clear();
                    AddPlayer(players);
                }
                else if(option == "2")
                {
                    Console.Clear();
                    AddSkill(skills);
                }
                else if(option == "3")
                {
                    Console.Clear();
                    ViewPlayers(players);
                }
                else if(option == "4")
                {
                    Console.Clear();
                    LearnSkill(players, skills);
                }
                else if(option == "5")
                {
                    Console.Clear();
                    AttackPlayer(players);
                }
                else if(option == "6")
                {
                    Environment.Exit(0);
                }
                else
                {
                    PressAnyKey("Wrong userInput!");
                }
            }
        }
        static string Menu()
        {
            Console.WriteLine("1.Add Player");
            Console.WriteLine("2.Add Skill Stats");
            Console.WriteLine("3.View Players Stats");
            Console.WriteLine("4.Learn Skill");
            Console.WriteLine("5.Attack a player");
            Console.WriteLine("6.Exit");
            Console.Write("Enter option...");
            return Console.ReadLine();
        }
        static void AddPlayer(List<Player> players)
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            Console.Write("Enter player health: ");
            double hp = double.Parse(Console.ReadLine());
            Console.Write("Enter player energy: ");
            double energy = double.Parse(Console.ReadLine());
            Console.Write("Enter player armor: ");
            double armor = double.Parse(Console.ReadLine());
            Player p = new Player(name, hp, energy, armor);
            if(PlayerCheck(players,p.name)==false)
            {
                players.Add(p);
                PressAnyKey("Player added successfully!");
            }
            else
            {
                PressAnyKey("Player already exists!");
            }
        }
        static void AddSkill(List<Stats> skills)
        {
            Console.Write("Enter skill name: ");
            string name = Console.ReadLine();
            Console.Write("Enter skill damage: ");
            double damage = double.Parse(Console.ReadLine());
            Console.Write("Enter skill penetration: ");
            double penetration = double.Parse(Console.ReadLine());
            Console.Write("Enter skill heal: ");
            double heal = double.Parse(Console.ReadLine());
            Console.Write("Enter skill cost: ");
            double cost = double.Parse(Console.ReadLine());
            Console.Write("Enter skill description: ");
            string description = Console.ReadLine();
            Stats s = new Stats(name, damage,penetration,heal,cost,description);
            if (SkillCheck(skills, s)==false)
            {
                skills.Add(s);
                PressAnyKey("Skill added successfully!");
            }
            else
            {
                PressAnyKey("Skill already exists!");
            }
        }
        static void ViewPlayers(List<Player> players)
        {
            if(players.Count>0)
            {
                Console.WriteLine($"{"Name",-20}{"HP",-20}{"Energy",-20}{"Armor",-20}");
                foreach (Player player in players)
                {
                    Console.WriteLine($"{player.name,-20}{player.hp,-20}{player.energy,-20}{player.armor,-20}");
                }
                PressAnyKey("");
            }
            else
            {
                PressAnyKey("No player data found!");
            }
        }
        static void LearnSkill(List<Player> players,List<Stats> skills)
        {
            Console.Write("Enter the player name: ");
            string playerName=Console.ReadLine();
            if (PlayerCheck(players,playerName)==true)
            {
                int pidx=PlayerIDX(players,playerName);
                if(skills.Count>0)
                {
                    Console.WriteLine($"{"Skill",-20}{"Damage",-20}{"Penetration",-20}{"Heal",-20}{"Cost",-20}{"Description"}");
                    foreach (Stats skill in skills)
                    {
                        Console.WriteLine($"{skill.skillname,-20}{skill.damage,-20}{skill.penetration,-20}{skill.heal,-20}{skill.cost,-20}{skill.description}");
                    }
                    Console.Write("Enter skill number to add skills: ");
                    int index;
                    while(true)
                    {
                        index=int.Parse(Console.ReadLine());
                        if (index>0 && index<=skills.Count)
                        {
                            break;
                        }
                    }
                    index--;
                    players[pidx].LearnSkill(skills[index]);
                    PressAnyKey("Skill learnt successfully!");
                }
                else
                {
                    PressAnyKey("No skill available!");
                }
            }
            else
            {
                PressAnyKey("Player not found!");
            }
        }
        static void AttackPlayer(List<Player> players)
        {
            Console.Write("Enter attacking player: ");
            string playerName=Console.ReadLine();
            Console.Write("Enter target player: ");
            string target = Console.ReadLine();
            if(PlayerCheck(players,playerName)==true)
            {
                int attackIdx=PlayerIDX(players,playerName);
                if(PlayerCheck(players,target)==true)
                {
                    int targetIDX=PlayerIDX(players,target);
                    Console.WriteLine(players[attackIdx].Attack(players[targetIDX]));
                    PressAnyKey("");
                }
                else
                {
                    PressAnyKey("No target player found!");
                }
            }
            else
            {
                PressAnyKey("No attacking player found!");
            }
        }
        static int PlayerIDX(List<Player> players,string playerName)
        {
            for(int i=0;i<players.Count;i++)
            {
                if (players[i].name==playerName)
                {
                    return i;
                }
            }
            return -1;
        }
        static bool SkillCheck(List<Stats> skills, Stats s)
        {
            foreach (Stats skill in skills)
            {
                if(skill.skillname == s.skillname)
                {
                    return true;
                }
            }
            return false;
        }
        static bool PlayerCheck(List<Player> players, string player)
        {
            foreach (Player p in players)
            {
                if(p.name==player)
                {
                    return true;
                }    
            }
            return false;
        }
        static void PressAnyKey(string statement)
        {
            Console.WriteLine(statement);
            Console.Write("Press any key to conitnue!");
            Console.ReadKey();
        }
    }
}

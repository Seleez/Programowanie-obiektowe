using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace strategia
{
    public interface IStrategy
    {
        void attack(Character cel);
    }
    public class Character
    {
        public string name { get; set; }
        public IStrategy strategy { get; set; }

        public Character(string name, IStrategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        public void changeStrategy(IStrategy newStrategy)
        {
            strategy = newStrategy;
        }
        public void attack(Character cel) {
            strategy.attack(cel);
        }
    }

    public class Magic : IStrategy
    {
        public void attack(Character cel)
        {
            Console.WriteLine($"You cast spell on {cel}");
        }
    }
    public class Melee : IStrategy
    {
        public void attack(Character cel)
        {
            Console.WriteLine($"You hit {cel.name} with a sword");
        }
    }
    public class Ranged : IStrategy
    {
        public void attack(Character cel)
        {
            Console.WriteLine($"You shoot {cel.name} with an arrow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Magic magicAttack = new Magic();
            Melee meleeAttack = new Melee();
            Ranged rangedAttack = new Ranged();
            Character Enemy = new Character("Enemy", rangedAttack);
            Character MC = new Character("s", meleeAttack);
            MC.attack(Enemy);
            MC.changeStrategy(rangedAttack);
            MC.attack(Enemy);
        }
    }
}

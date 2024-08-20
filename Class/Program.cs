using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Andry", "sword", 100);

            player.ShowInfo();
        }
    }

    class Player
    {
        private string _name;
        private string _weapon;
        private int _health;

        public Player(string name, string weapon, int health) 
        {
            _name = name;
            _weapon = weapon;
            _health = health;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Игрок по имени {_name} держит в руках {_weapon} и имеет {_health} здоровья");
        }
    }
}

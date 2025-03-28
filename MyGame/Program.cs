using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[Convert.ToInt32(args[0])];
            for(int i=0; i<Convert.ToInt32(args[0]);i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();
                enemies[i] = new Enemy(name);
            }
            enemies[0].PickupPowerUp(PowerUp.Health,20);
            enemies[1].PickupPowerUp(PowerUp.Health,20);




            foreach (var enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }
            Console.WriteLine($"{enemies[0].GetPowerUps()}");
        }
    }
}

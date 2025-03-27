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
            enemies[0].PickupPowerUp(PowerUp.Health, 200);
            enemies[0].TakeDamage(50);
            enemies[0].PickupPowerUp(PowerUp.Shield, 100);
            enemies[0].TakeDamage(67);
            foreach (var enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }

        }
    }
}

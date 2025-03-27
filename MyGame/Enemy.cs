using System;

namespace Enemy
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name )
        {
            this.name = name; // name o c u l t a t h i s . name
            health = 100;
            shield = 0;
        }

    }


}
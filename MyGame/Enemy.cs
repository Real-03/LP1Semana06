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
            this.name = SetName(name); // name o c u l t a t h i s . name
            health = 100;
            shield = 0;
        }

        public string GetName ( )
        {
            return name ;
        }
        public float GetHealth ( )
        {
            return health ;
        }
        public float GetShield ( )
        {
            return shield ;
        }

        public void TakeDamage (float damage)
        {
            shield -= damage ;
            if (shield<0)
            {
                float damageStillToInflict = -shield ;
                shield = 0 ;
                health -= damageStillToInflict ;
                if(health<0) health = 0 ;
            }
        }

        public string SetName(string name)
        {
            return name.Substring(0, 8);
        }


    }


}
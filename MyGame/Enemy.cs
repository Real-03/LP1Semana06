using System;
      
    public class Enemy
    {


        private string name;
        private float health;
        private float shield;
        private static  int p;

        public Enemy(string name )
        {
            this.name = SetName(name); // name o c u l t a t h i s . name
            health = 100;
            shield = 0;
            p=0;
        }

        public string GetName ()
        {
            return name ;
        }
        public float GetHealth ()
        {
            return health ;
        }
        public float GetShield ()
        {
            return shield ;
        }
        public int GetPowerUps ()
        {
            return p ;
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
            if(name.Length>8)
                return name.Substring(0, 8);
            else
                return name;
        }

        public void PickupPowerUp(PowerUp type, float value)
        {
            p++;
            if(type == PowerUp.Health)
            {
                health+=value;
                    if(health>100)
                        health = 100;
            }
            if(type == PowerUp.Shield)
            {
                shield += value;
                    if(shield>100)
                        shield = 100;
            }

        }


    }

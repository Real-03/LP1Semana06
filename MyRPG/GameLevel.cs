using System;
using Humanizer;

    public class GameLevel
    {

        private string[] rooms;
        private Hardness levelDificult;
        

        public GameLevel(int rooms,Hardness type )
        {
            this.rooms = new string[rooms]; // name o c u l t a t h i s . name
            levelDificult = type;
        }

        public void SetEnemyInRoom(int room,Enemy enemy)
        {
            if(rooms[room] == null)
                rooms[room] = enemy.GetName();
        }

        public string GetHardness ()
        {
            return Convert.ToString(levelDificult) ;
        }
         public string GetNumRooms ()
        {
            return Convert.ToString(rooms.Length) ;
        }
         public string GetNumEnemies ()
        {
            int totalEnemy = 0;

            foreach (var room in rooms)
            {
                if(room !=null)
                    totalEnemy+=1;
            }
            return Convert.ToString(totalEnemy) ;
        }


        public void PrintEnemies()
        {
            int roomNumber = 0;
            foreach (var room in rooms)
            {
                
                if(room !=null)
                {
                    Console.WriteLine($"Room {roomNumber.ToRoman()}: {room}");
                }
                roomNumber+=1;
            }
        }


        

        

    }
    
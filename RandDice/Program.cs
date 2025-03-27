using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random RandomNumber = new Random(Convert.ToInt32(args[1]));
            int total =0;
            for(int i= 0; i<Convert.ToInt32(args[0]); i++)
            {
                total+= RandomNumber.Next(1,6);
            }
            
            Console.WriteLine(total);

        }
    }
}

using System;

namespace MinesWeeper
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();

            bool[] n = new bool[100];

            for (int i = 0; i < 90; i++)
                n[i] = false;

            for (int i = 90; i < 100; i++)
                n[i] = true;

            for(int i=0; i<100; i++)
            {
                int pos = rand.Next(100);
                bool save = n[i];
                n[i] = n[pos];
                n[pos] = save;
            }

            for(int i = 0; i < 100; i++)
            {
                if (n[i])
                    Console.Write("* ");
                else
                    Console.Write(". ");
                if((i+1)%10==0)
                    Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

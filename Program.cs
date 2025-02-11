using System.Data;

namespace L20250211
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Random rand = new Random();

            int goblinCount = rand.Next(1, 3);
            Goblin[] goblins = new Goblin[goblinCount];
            for (int i = 0; i < goblins.Length; i++)
            {
                goblins[i] = new Goblin();
            }


            int slimeCount = rand.Next(1, 5);
            Slime[] slimes = new Slime[slimeCount];
            for (int i = 0; i < slimes.Length; i++)
            {
                slimes[i] = new Slime();
            }

            int boarCount = rand.Next(1, 3);
            Boar[] boars = new Boar[boarCount];
            for (int i = 0; i < boars.Length; i++)
            {
                boars[i] = new Boar();
            }

            while (true)
            {
                //Input();
                Console.ReadKey();
                Console.Clear();

                //Update();
                player.Move();
                for (int i = 0; i < goblins.Length; i++)
                {
                    goblins[i].Move();
                }
                for (int i = 0; i < slimes.Length; i++)
                {
                    slimes[i].Move();
                }
                for (int i = 0; i < boars.Length; i++)
                {
                    boars[i].Move();
                }

                //Render();

            }

        }
    }
}

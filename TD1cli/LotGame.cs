using System;

namespace TD1cli
{
    public class LotGame
    {
        private int x;
        private int essai;

        public LotGame(int range)
        {
            Random alea = new Random();
            this.x = alea.Next(range);
            this.essai = 0;
        }

        public bool Testing(int number)
        {
            this.essai++;
            if (number == this.x)
            {
                Console.WriteLine("BRAVO ! Vous avez trouvé en " + this.essai + " essais.");
                return false;
            }

            if (number > this.x)
                Console.WriteLine("Trop grand");
            else
                Console.WriteLine("Trop petit");
            return true;
        }

        public int Testing_GUI(int number)
        {
            this.essai++;
            if (number == this.x)
            {
                Console.WriteLine("BRAVO ! Vous avez trouvé en " + this.essai + " essais.");
                return 0;
            }

            if (number > this.x)
            {
                Console.WriteLine("Trop grand");
                return 1;
            }
            Console.WriteLine("Trop petit");
            return 2;
        }
        
        public void AI_Testing(LotGame game, int min, int max)
        {
            if (max < min)
                (max, min) = (min, max);
            int code = game.Testing_GUI(min + (max - min) / 2);
            if (code == 0)
                return;
            if (code == 1)
                AI_Testing(game, min, min + (max - min) / 2);
            else
                AI_Testing(game, min + (max - min) / 2, max);
        }
    }
}
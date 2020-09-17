using System;

namespace Exo2
{
    class Article
    {
        public int prix = 0;

        public int Prix
        {
            get => prix;
            set => prix = value;
        }


        public void affichePrix()
        {
            Console.WriteLine("Prix: {0} euros", Prix);
        }

        

        static void Main(string[] args)
        {
            Article A = new Article();
            A.Prix = 10;
            A.affichePrix();
        }
    }
}
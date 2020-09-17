using System;

namespace Exo1
{
    class TabClasse
    {
        private int nbMaxElts;
        private int[] tab;
        private int nbElts;

        public TabClasse(int userNbMaxElts)
        {
            this.nbMaxElts = userNbMaxElts;
            this.nbElts = 0;
        }

        public void remplirTableau(int userNbElts)
        {
            this.nbElts = userNbElts;
            this.tab = new int[this.nbElts];

            for (int i = 0; i < this.tab.Length; i ++)
            {
                Console.WriteLine("Veuillez saisir l'entier " + (i + 1) + "/" + tab.Length + " : ");
                this.tab[i] = int.Parse(Console.ReadLine());
            }
        }

        public void afficherTableau()
        {
            String str = "";
            
            str += "Affichage Tableau : \n[";
            
            for (int i = 0; i < this.tab.Length; i++)
            {
                str += tab[i];
                
                if (i < (this.tab.Length - 1))
                {
                    str += ", ";
                }
            }

            str += "]";
            
            Console.WriteLine(str);
        }

        public void trierTableau()
        {
            int min;
            int indiceTab = 0;
            bool minTrouve = false;
            for (int i = 0; i < this.tab.Length; i++)
            {
                min = this.tab[i];
                for (int j = (i + 1); j < this.tab.Length; j++)
                {
                    if (min > this.tab[j])
                    {
                        min = this.tab[j];
                        indiceTab = j;
                        minTrouve = true;
                    }
                }

                if (minTrouve)
                {
                    this.tab[indiceTab] = this.tab[i];
                    this.tab[i] = min; 
                }

                minTrouve = false;
            }
        }

        public int NbElts
        {
            get => nbElts;
            set => nbElts = value;
        }

        public int NbMaxElts
        {
            get => nbMaxElts;
            set => nbMaxElts = value;
        }

        public int this[int indiceElts]
        {
            get{return tab[indiceElts];}
            set {tab[indiceElts] = value;}
        }

        public int getInt(int indiceElts)
        {
            return this.tab[indiceElts];
        }

        public void setInt(int indiceElts, int valeur)
        {
            this.tab[indiceElts] = valeur;
        }
        
        static void Main(string[] args)
        {
            TabClasse userTab = new TabClasse(10);

            userTab.remplirTableau(5);
            userTab.afficherTableau();
            Console.WriteLine(userTab.getInt(4));
            userTab.setInt(4, 42);
            userTab.afficherTableau();
            userTab.trierTableau();
            userTab.afficherTableau();
        }
    }
}
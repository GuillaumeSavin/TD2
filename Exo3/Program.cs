using System;
using System.Linq;

namespace Exo3
{
    public class Personnes
    {
        private String[] m_Noms;
        private int m_NbElt;
        private int m_Max;

        public Personnes(int Max)
        {
            this.m_Max = Max;
            this.m_NbElt = 0;
            this.m_Noms = new string[Max];
        }

        public int this[String Nom]
        {
            get
            {
                for (int i = 0; i < this.m_Noms.Length; i ++)
                {
                    if (Nom == this.m_Noms[i])
                    {
                        return i;
                    }

                    
                }
                return -1;
            }
        }

        public String this[int i]
        {
            get
            {
                if (i > this.m_NbElt)
                {
                    return null;
                }
                return this.m_Noms[i];
            }
            set
            {
                if (i < this.m_NbElt)
                {
                    this.m_Noms[i] = value;
                }
                
                if (((i +1) > this.m_NbElt) && (i < this.m_Max))
                {
                    this.m_NbElt++;
                    this.m_Noms[i] = value;

                }


            }
        }
    }

    class Prog
    {
        static void Main(String[] args)
        {
            Personnes Tableau = new Personnes(4);
            Tableau[0] = "Anna";
            Tableau[1] = "Ingrid";
            Tableau[2] = "Maria";
            Tableau[3] = "Ulrika";
            Tableau[0] = "Kanade";
            Console.WriteLine(Tableau[1]);
            Console.WriteLine(Tableau["Maria"]);
            Console.WriteLine(Tableau[10]);
            Console.WriteLine(Tableau["Toto"]);
        }
    }
}
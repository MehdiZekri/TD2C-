using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace td2
{
    class Program
    {
        static void AfficherMois(string[] mois)
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(mois[i]);
            }
        }

        static void Main()
        {
            string[] mois = new string[12];
            mois[0] = "Janvier";
            mois[1] = "Février";
            mois[2] = "Mars";
            mois[3] = "Avril";
            mois[4] = "Mai";
            mois[5] = "Juin";
            mois[6] = "Juillet";
            mois[7] = "Août";
            mois[8] = "Septembre";
            mois[9] = "Octobre";
            mois[10] = "Novembre";
            mois[11] = "Décembre";

            Console.WriteLine("Choisissez une option :");
            Console.WriteLine("1. Lister les noms des 12 mois.");
            Console.WriteLine("2. Lister les noms des 12 mois avec les mois contenant un R en rouge.");
            Console.WriteLine("3. Lister les 12 mois avec leur numéro.");

            int choixUtilisateur = int.Parse(Console.ReadLine());

            if (choixUtilisateur == 1)
            {
                AfficherMois(mois);
            }
            else if (choixUtilisateur == 2)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (mois[i].Contains("R") || mois[i].Contains("r"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.WriteLine(mois[i]);

                    if (mois[i].Contains("R") || mois[i].Contains("r"))
                    {
                        Console.ResetColor();
                    }
                }
            }
            else if (choixUtilisateur == 3)
            {
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine((i + 1) + " " + mois[i]);
                }
            }
            else
            {
                Console.WriteLine("Choix invalide. Veuillez choisir 1, 2 ou 3.");
            }

            Console.ReadLine();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnSituationEntrevue.Question1
{
    /**
     * Faire une boucle de 1 à 100 qui va afficher "Béton Provincial" à tous les multiples de 3
     * et "Informatique" à tous les multiples de 5.
     * Résultat attendu :
     * 3 - Béton Provincial
     * 5 - Informatique
     * 6 - Béton Provincial
     * 9 - Béton Provincial
     * 10 - Informatique
     * 12 - Béton Provincial
     * 15 - Béton Provincial
     * 15 - Informatique
     * ...
     */
    #region English comments
    /**
     * Make a loop from 1 to 100 that will output "Beton Provincial" when value is a multiple of
     * 3 and "Computer" when value is a multiple of 5.
     * Expected result : 
     * 3 - Beton Provincial
     * 5 - Computer
     * 6 - Beton Provincial
     * 9 - Beton Provincial
     * 10 - Computer
     * 12 - Beton Provincial
     * 15 - Beton Provincial
     * 15 - Computer
     * ...
     */
    #endregion
    public static class Launcher
    {
        public static void Execute()
        {
            // Implémentation ici.

            #region Réponse/Answer (en commentaire)
            /*
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("{0:000} - Béton Provincial", i);
                if (i % 5 == 0)
                    Console.WriteLine("{0:000} - Informatique", i);
            }
            */
            #endregion

            Console.WriteLine("Fin de la question. Appuyez sur entrée pour continuer.");
            Console.ReadLine();
        }
    }
}

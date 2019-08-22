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
     * Ligne #3 - Béton Provincial
     * Ligne #5 - Informatique
     * Ligne #6 - Béton Provincial
     * Ligne #9 - Béton Provincial
     * Ligne #10 - Informatique
     * Ligne #12 - Béton Provincial
     * Ligne #15 - Béton Provincial
     * Ligne #15 - Informatique
     * ...
     */
    #region English comments
    /**
     * Make a loop from 1 to 100 that will output "Beton Provincial" when line number is a multiple of
     * 3 and "Computer" when line number is a multiple of 5.
     * Expected result : 
     * Line #3 - Beton Provincial
     * Line #5 - Computer
     * Line #6 - Beton Provincial
     * Line #9 - Beton Provincial
     * Line #10 - Computer
     * Line #12 - Beton Provincial
     * Line #15 - Beton Provincial
     * Line #15 - Computer
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
                    Console.WriteLine("Ligne #{0:000} - Béton Provincial", i);
                if (i % 5 == 0)
                    Console.WriteLine("Ligne #{0:000} - Informatique", i);
            }
            */
            #endregion

            Console.WriteLine("Fin de la question. Appuyez sur entrée pour continuer.");
            Console.ReadLine();
        }
    }
}

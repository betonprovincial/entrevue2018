using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnSituationEntrevue
{
    class Program
    {
        /**
         * Notes concernant le test C#
         * - Durée : 20 minutes
         * - Un employé de notre département TI prendra 5 à 10 minutes pour lire le test avec vous et répondre à vos questions.
         * - Le test comporte 3 questions (Question1, Question2A and Question2B)
         * - Évaluation C# uniquement (pas de Web, pas d'Entity Framework, etc.)
         * - Tout le code du test se trouve dans la solution.
         * - Conseil/rappel : L'instruction pour afficher à l'écran (dans la console) est : Console.WriteLine(...)
         * - En tout temps vous pouvez utiliser Internet.
         */
        #region English comments
        /**
         * Notes about the C# test
         * - Duration : 20 minutes
         * - An employee from our IT team will take 5 to 10 minutes to read the test and answer any question.
         * - The test has 3 questions (Question1, Question2A and Question2B)
         * - Based on C# only (no Web, no Entity Framework, etc.)
         * - All the code is in the solution.
         * - Hint/reminder : The instruction to write in the console is : Console.WriteLine(...)
         * - You are allowed to use Internet at any time.
         */
        #endregion

        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 40);

            // FR - Lorsqu'une question est complétée, commentez son "launcher" et décommentez le suivant.
            // EN - After completing a question, comment its launcher and uncomment the next one.
            Question1.Launcher.Execute();
            //Question2.Launcher.ExecuteA();
            //Question2.Launcher.ExecuteB();
        }
    }
}

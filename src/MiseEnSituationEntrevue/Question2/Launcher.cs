using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnSituationEntrevue.Question2
{
    /**
     * On a accès aux données suivantes via la classe "Data".
     * Data.Produits - Une liste de produits (classe Produit) disponibles dans le système (code, description, prix unitaire par défaut)
     * Data.Clients - Une liste de clients (classe Client) de l'entreprise (code et nom)
     * Data.EntentesDePrix - Une liste de prix spéciaux (classe EntenteDePrix) avec certains clients pour certains produits 
     * (code du client, code de produit et prix unitaire entendu).
     * 
     * Pour plus d'information tu peux aller voir le code dans la classe Data.
     */
    #region English comments
    /**
     * We have access to the following information with the "Data" class.
     * Data.Produits - List of the products ("Produit" class) available in the system (code, description, default unit price)
     * Data.Clients - List of customer ("Client" class) of the company (code and name)
     * Data.EntentesDePrix - List of special prices ("EntenteDePrix" class) that some customers have for some products (customer code,
     * product code, special unit price).
     * 
     * For more information, you can look through the code of the "Data" class.
     */
    #endregion
    public static class Launcher
    {
        /**
         * On veut afficher les ententes de prix (Data.EntentesDePrix) avec une ligne par client.
         * Résultat attendu est le suivant (on s'attend à avoir uniquement ces 3 lignes affichées) :
         * Client #2 -> BETONA (131.00$), BETONB (126.00$), EXTRA1 (4.00$)
         * Client #6 -> BETONB (150.00$), EXTRA2 (4.50$)
         * Client #7 -> EXTRA4 (55.00$), EXTRA2 (5.50$)
         * Note : BETONA, BETONB, EXTRA1, etc. correspondent au code des produits.
         */
        #region English comments
        /**
         * We want to display the special prices (Data.EntentesDePrix) with one line per customer.
         * The expected result is the following (we expect only these 3 lines) :
         * Customer #2 -> BETONA (131.00$), BETONB (126.00$), EXTRA1 (4.00$)
         * Customer #6 -> BETONB (150.00$), EXTRA2 (4.50$)
         * Customer #7 -> EXTRA4 (55.00$), EXTRA2 (5.50$)
         * Note : BETONA, BETONB, EXTRA1, etc. are product codes.
         */
        #endregion
        public static void ExecuteA()
        {
            var listeDePrix = Data.EntentesDePrix;

            #region Réponse/Answer (en commentaire)
            /*
            // Notes concernant la réponse en exemple
            // 1) Pour récupérer "ententesPourClientCourant" on aurait pu utiliser la méthode d'extension .TrouverParClient(...)
            // 2) LINQ a été utilisé, mais une solution avec des boucles (for/foreach) aurait été tout aussi appropriée (par exemple pour bâtir plStr).
            // 3) La méthode d'extension .ProduitEtPrixToString() aurait pu être utilisée à la place de faire string.Format(...)
            
            var codeClientUnique = listeDePrix.Select(x => x.CodeClient).Distinct().ToList();
            foreach (var codeClient in codeClientUnique)
            {
                var ententesPourClientCourant = listeDePrix.Where(x => x.CodeClient == codeClient);
                var produitPrixTextes = ententesPourClientCourant.Select(ep => string.Format("{0} ({1:N2}$)", ep.CodeProduit, ep.PrixUnitaire));
                var sommaireDesPrix = string.Join(", ", produitPrixTextes);
                Console.WriteLine("Client #{0} : {1}", codeClient, sommaireDesPrix);
            }
            */
            #endregion

            ConsoleWriteFinDeQuestion();
        }

        /**
         * On fournit un numéro de client et des lignes de facture sans prix.
         * On désire compléter les lignes de facture pour y indiquer le prix de facturation.
         * - Si le client a une entente de prix pour le produit, on va lui charger le prix indiqué sur l'entente.
         * - Sinon, on va lui charger le prix par défaut (qui se trouve sur la fiche produit).
         * On veut également indiquer sur la ligne de facture quelle est la provenance du prix indiqué.
         */
        #region English comments
        /**
         * We provide you a customer number and a list of invoice lines without price.
         * We want to complete the lines and set the invoicing price.
         * - If the customer has a special price for the product, we bill him the special unit price.
         * - Otherwise, we will bill him the default unit price (specified on the product item).
         * We also want to specify the source of the price on the invoice line object.
         */
        #endregion
        public static void ExecuteB()
        {
            // Initialisation.
            var codeClient = 2; // FR - Ne changez pas ce numéro de client. // EN - Do not change this customer number.
            var lignesFacture = GetLignesFactureSansPrix();
            var listeDePrix = Data.EntentesDePrix;
            var listeProduits = Data.Produits;

            // FR - Pour aider à faire la trace lorsque vous lancerez l'application. // EN - To help you debug when you'll launch the program.
            ConsoleWriteLignesDeFacture(lignesFacture, "**** Les lignes sans prix ****");

            #region Réponse/Answer (en commentaire)
            /*
            // Notes concernant la réponse en exemple
            // 1) La méthode d'extension .TrouverParClientEtProduit(...) aurait pu être utilisée pour identifier le prix de l'entente.
            // 2) La méthode d'extension .TrouverParCodeProduit(...) aurait pu être utilisée pour trouver le produit dans la liste.

            foreach (var l in lignesFacture)
            {
                var prixEntente = listeDePrix.FirstOrDefault(x => x.CodeClient == codeClient && x.CodeProduit == l.CodeProduit);
                if (prixEntente != null)
                {
                    l.PrixUnitaire = prixEntente.PrixUnitaire;
                    l.SourceDuPrix = SourcePrix.EntenteDePrix;
                }
                else
                {
                    l.PrixUnitaire = listeProduits.Where(x => x.Code == l.CodeProduit).Select(x => x.PrixUnitaireDeListe).First();
                    l.SourceDuPrix = SourcePrix.PrixDeListe;
                }
            }
            */
            #endregion

            // FR - Pour aider à faire la trace lorsque vous lancerez l'application. // EN - To help you debug when you'll launch the program.
            ConsoleWriteLignesDeFacture(lignesFacture, "**** Après l'application des prix ****");
            ConsoleWriteFinDeQuestion();
        }


        #region Fonctions helper.
        /**
         * Ne pas t'inspirer du code ci-dessous car mauvais exemple.
         */

        private static void ConsoleWriteFinDeQuestion()
        {
            Console.WriteLine("Fin de la question. Appuyez sur entrée pour continuer.");
            Console.ReadLine();
        }

        private static IList<LigneFacture> GetLignesFactureSansPrix()
        {
            return new List<LigneFacture>()
            {
                new LigneFacture() { CodeProduit = "BETONB", Quantite = 10.00m },
                new LigneFacture() { CodeProduit = "BETONA", Quantite =  5.00m },
                new LigneFacture() { CodeProduit = "EXTRA4",  Quantite =  0.50m }
            };
        }

        private static void ConsoleWriteLignesDeFacture(IList<LigneFacture> lignesFacture, string messageTitre)
        {
            Console.WriteLine(messageTitre);
            foreach (var l in lignesFacture)
            {
                Console.WriteLine("Produit : " + l.CodeProduit.PadLeft(10) + " Quantité : " + l.Quantite.ToString("#####0.00").PadLeft(6) + " Prix unitaire : " + l.PrixUnitaire.ToString("#####0.00").PadLeft(8) + " Source : " + l.SourceDuPrix);
            }
        }
        #endregion

    }
}

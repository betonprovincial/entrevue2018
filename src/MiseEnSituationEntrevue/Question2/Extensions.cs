using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnSituationEntrevue.Question2
{
    static class Extensions
    {
        public static IList<EntenteDePrix> TrouverParClient(this IList<EntenteDePrix> ententesDePrix, int codeClient)
        {
            return ententesDePrix.Where(x => x.CodeClient == codeClient).ToList();
        }

        public static string ProduitEtPrixToString(this EntenteDePrix ententeDePrix)
        {
            return string.Format("{0} ({1:N2}$)", ententeDePrix.CodeProduit, ententeDePrix.PrixUnitaire);
        }

        public static EntenteDePrix TrouverParClientEtProduit(this IList<EntenteDePrix> ententesDePrix, int codeClient, string codeProduit)
        {
            return ententesDePrix.FirstOrDefault(x => x.CodeClient == codeClient && x.CodeProduit == codeProduit);
        }

        public static Produit TrouverParCodeProduit(this IList<Produit> produits, string codeProduit)
        {
            return produits.FirstOrDefault(x => x.Code == codeProduit);
        }

    }
}

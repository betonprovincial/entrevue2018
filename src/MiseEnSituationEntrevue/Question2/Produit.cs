using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnSituationEntrevue.Question2
{
    class Produit
    {
        public Produit()
        {
            
        }

        public Produit(string code, string description, decimal prixUnitaireDeListe)
        {
            Code = code;
            Description = description;
            PrixUnitaireDeListe = prixUnitaireDeListe;
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public decimal PrixUnitaireDeListe { get; set; }
    }
}

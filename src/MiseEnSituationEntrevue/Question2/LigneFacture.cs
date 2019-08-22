using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnSituationEntrevue.Question2
{
    class LigneFacture
    {
        public string CodeProduit { get; set; }
        public decimal Quantite { get; set; }
        public decimal PrixUnitaire { get; set; }
        public SourcePrix SourceDuPrix { get; set; }
    }
}

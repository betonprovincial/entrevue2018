using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnSituationEntrevue.Question2
{
    static class Data
    {
        public static IList<Produit> Produits = new List<Produit>()
        {
            new Produit { Code = "BETONA", Description = "Béton standard 25 MPa",   PrixUnitaireDeListe = 150.00m },
            new Produit { Code = "BETONB", Description = "Béton standard 30 MPa",   PrixUnitaireDeListe = 152.00m },
            new Produit { Code = "BETONC", Description = "Béton standard 35 MPa",   PrixUnitaireDeListe = 160.00m },
            new Produit { Code = "EXTRA1", Description = "Frais de carburant",      PrixUnitaireDeListe =   5.25m },
            new Produit { Code = "EXTRA2", Description = "Frais environnemental",   PrixUnitaireDeListe =   3.00m },
            new Produit { Code = "EXTRA3", Description = "Frais superplastifiant",  PrixUnitaireDeListe =  10.00m },
            new Produit { Code = "EXTRA4", Description = "Frais transport",         PrixUnitaireDeListe = 100.00m },
            new Produit { Code = "EXTRA5", Description = "Frais produit spécial",   PrixUnitaireDeListe =   8.00m }
        };

        public static IList<Client> Clients = new List<Client>()
        {
            new Client() { Id =  1, Nom = "Monsieur Turcotte" },
            new Client() { Id =  2, Nom = "Centre commercial A" },
            new Client() { Id =  3, Nom = "Monsieur Dumont" },
            new Client() { Id =  4, Nom = "Les entreprises ABC" },
            new Client() { Id =  5, Nom = "Ville de Québec" },
            new Client() { Id =  6, Nom = "Monsieur Roy" },
            new Client() { Id =  7, Nom = "Ville de Montréal" },
            new Client() { Id =  8, Nom = "Construction piscine inc." },
            new Client() { Id =  9, Nom = "Maison fondation inc." },
            new Client() { Id = 10, Nom = "Madame Lirette" }
        };

        public static IList<EntenteDePrix> EntentesDePrix = new List<EntenteDePrix>()
        {
            new EntenteDePrix() { CodeClient = 2, CodeProduit = "BETONA", PrixUnitaire = 131.00m },
            new EntenteDePrix() { CodeClient = 2, CodeProduit = "BETONB", PrixUnitaire = 126.00m },
            new EntenteDePrix() { CodeClient = 2, CodeProduit = "EXTRA1", PrixUnitaire =   4.00m },
            new EntenteDePrix() { CodeClient = 6, CodeProduit = "BETONB", PrixUnitaire = 150.00m },
            new EntenteDePrix() { CodeClient = 6, CodeProduit = "EXTRA2", PrixUnitaire =   4.50m },
            new EntenteDePrix() { CodeClient = 7, CodeProduit = "EXTRA4", PrixUnitaire =  55.00m },
            new EntenteDePrix() { CodeClient = 7, CodeProduit = "EXTRA2", PrixUnitaire =   5.50m },
        };
    }
    
}

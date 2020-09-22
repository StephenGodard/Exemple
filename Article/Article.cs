using System;

namespace Articlee
{
    public struct Article
    {
        public Article(string name, double prix, int quantite)
        {
            this.Nom = name;
            this.Prix = prix;
            this.Quantite = quantite;
        }

        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }

        public string Infos()
        {
            return  $"Nom : {Nom}, Prix : {Prix}, Quantite : {Quantite}";
        }

        public void Afficher()
        {
            Console.WriteLine(this.Infos());
        }

        public void Ajouter(int add)
        {
            Quantite += add;
        }

        public void Retirer(int remove)
        {
            Quantite -= remove;
        }
    }
}
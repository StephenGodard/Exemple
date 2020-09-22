using System.Collections.Generic;
using System.Text;
using System;

namespace exo3
{
    public struct Article
    {
        public Article(string name, double prix, int quantite,Type type)
        {
            this.Nom = name;
            this.Prix = prix;
            this.Quantite = quantite;
            this.TypeArticle = type;
        }

        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }

        public Type TypeArticle { get; set; }

        public string Infos()
        {
            return $"Nom : {Nom}, Prix : {Prix}, Quantite : {Quantite},Type: {TypeArticle}";
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

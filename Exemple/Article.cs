using System;
using System.Collections.Generic;
using System.Text;

namespace Articlee
{
    public class Article
    {
        public string Designation { get; set; }
        public double Prix { get; set; }
        public Article(string design,double prix)
        {
            this.Designation = design;
            this.Prix = prix;
        }
        public Article()
        {
        }
        public  void Acheter()
        {
            Console.WriteLine("Prix de l'article" + Designation + Prix);

        }
    }
};
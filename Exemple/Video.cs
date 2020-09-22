using System;
using System.Collections.Generic;
using System.Text;
using Articlee;

    public class Video:Article
    {
        public double Duree { get; set; }
        public Video(double duree,double prix, string designation)
        {
            this.Duree = duree;
            this.Prix = prix;
            this.Designation = designation;
        }
        public Video(double duree)
        {
            this.Duree = duree;
        }
        public void afficher()
        {
        Console.WriteLine(Duree);

    }
    }


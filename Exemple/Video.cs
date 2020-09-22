using System;
using System.Collections.Generic;
using System.Text;
using Articlee;

    public class Video:Article
    {
        protected double Duree { get; set; }
        public Video(double duree,double prix, string designation)
        {
            this.Duree = duree;
            this.Prix = prix;
            this.Designation = designation;
        }
        public Video()
        {
            this.Duree = 0;
        }
        public double afficher()
        {
            return this.Duree;

        }
    }


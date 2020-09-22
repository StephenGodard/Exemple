using System;
using System.Collections.Generic;
using System.Text;
using Articlee;
       public class Disque:Article
    {
        public string Label { get; set; }
        public Disque(string label)
        {
        this.Label = label;

    }
        public Disque(string label,double prix,string designation)
         {
        this.Label = label;
        this.Prix = prix;
        this.Designation = designation;

         }
        public void ecouter()
        {
        Console.WriteLine(Label);

    }
    }


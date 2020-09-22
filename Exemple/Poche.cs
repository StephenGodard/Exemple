using System;
using System.Collections.Generic;
using System.Text;

namespace Articlee
{
    public class Poche : Livre
    {
        public string categorie { set; get; }
        public Poche(string categorie,double prix, string designation, int isbn, int nbPages,int isbnn, int nbpages)
        {
            this.categorie = categorie;
            this.Isbn = isbnn;
            this.NbPages = nbpages;
        }

    }
}

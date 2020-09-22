using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Articlee;

namespace Livree
{
    public class Livre:Article
    {
        protected int Isbn{ get; set; }
        private int NbPages { get; set;}
        public Livre()
        {
            this.Isbn = 0;
            this.NbPages = 0;
        }
        public Livre(int isbn,int nbPages,double prix,string designation)
        {
            this.Isbn = isbn;
            this.NbPages = nbPages;
            this.Prix = prix;
            this.Designation = designation;
        }
   
    }
}

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Articlee
{

    public class Livre : Article
    {
        public int Isbn { get; set; }
        public int NbPages { get; set; }
        public Livre(int isbn, int nbPages)
        {
            this.Isbn = isbn;
            this.NbPages = nbPages;
        }
        public Livre()
        {
            this.Isbn = 0;
            this.NbPages = 0;
        }
        public Livre(int isbn, int nbPages, double prix, string designation)
        {
            this.Isbn = isbn;
            this.NbPages = nbPages;
            this.Prix = prix;
            this.Designation = designation;
        }

    }

}
using System;
using System.Collections.Generic;
using System.Text;

namespace Articlee
{
    class Broche : Livre
    {
        public Broche(string designation, double prix,int isbn,int nbPages){
            this.Designation = designation;
            this.Prix = prix;
            this.Isbn = isbn;
            this.NbPages = nbPages;
        }
    }
}

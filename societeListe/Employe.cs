using System;
using System.Collections.Generic;
using System.Text;

namespace Societe
{
    class Employe : Personne
    {
        public int salaire { get; set; }

        public Employe(string nom, string prenom, int age, int salaire) : base(nom, prenom, age)
        {
           this.salaire = salaire;
        }

        public override string ToString()
        {
            return $"nom:{nom}, prenom:{prenom}, age:{age},salaire:{salaire}";
        }
      
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau
{
    class Directeur : Chef
    {
        public string societe { get; set; }
        public Directeur(string nom, string prenom, int age, int salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            this.societe = societe;
        }
        public override string ToString()
        {
            return base.ToString() + "societe:" + this.societe;
        }
    }
  
}

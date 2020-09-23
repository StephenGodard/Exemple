using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau
{
     class Chef : Employe
    {
        public string service { get; set; }

        public Chef(string nom, string prenom, int age, int salaire, string service) : base(nom, prenom, age, salaire)
        {
            this.service = service;
        }

        public override string ToString()
        {
            return $"nom:{nom}, prenom:{prenom}, age:{age},salaire:{salaire},service:{service}";
        }
    }
}
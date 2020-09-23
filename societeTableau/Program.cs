using System;
using System.Collections.Generic;

namespace SocieteTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe e1 = new Employe("Godard", "stephen", 24, 2000);
            Employe e2 = new Employe("Azerty", "Querty", 30, 1800);
            Employe e3 = new Employe("Personne 3", "Nom Personne 3", 19, 1600);
            Employe e4 = new Employe("Employe 4", "Nom Employe 4", 27, 2400);

            Chef c1 = new Chef("Chef 1", "nom Chef 1", 33, 3000,"Marketing");
            Chef c2 = new Chef("Chef 2", "nom Chef 2", 30, 3200, "Informatique");
            Directeur d = new Directeur("Directeur", "nom Directeur", 38,4500, "R&D", "Compas-nie");
            e1.salaire = 7000;
            c1.service = "Informatique";

            List<Personne> personneList = new List<Personne>()
            {
                e1,
                e2,
                e3,
                e4,
                c1,
                c2,
                d
            };
            for(int i = 0; i < personneList.Count; i++)
            {
                personneList[i].afficher();
            }
            personneList[0]++;
            
          

        }
    }
}

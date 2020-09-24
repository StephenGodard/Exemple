using ListeChainee;
using System;

namespace Societe
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe e1 = new Employe("Godard", "Numero 1", 24, 2000);
            Employe e2 = new Employe("Azerty", "Numero 2", 30, 1800);
            Employe e3 = new Employe("Personne 3", "Nom Personne 3", 19, 1600);
            Employe e4 = new Employe("Employe 4", "Nom Employe 4", 27, 2400);

            Chef c1 = new Chef("Chef 1", "nom Chef 1", 33, 3000, "Marketing");
            Chef c2 = new Chef("Chef 2", "nom Chef 2", 30, 3200, "Informatique");
            Directeur d = new Directeur("Directeur", "nom Directeur", 38, 4500, "R&D", "Compas-nie");
            e1.salaire = 7000;
            c1.service = "Informatique";

            Liste liste = new Liste();
            Console.WriteLine("Liste:\n");
            liste.InsererDebut(e1);
            liste.InsererDebut(e2);
            liste.InsererDebut(e3);
            liste.Lister();
            //on vide la liste
            Console.WriteLine("liste vide");
            liste.Vider();
            //on remplis aves la fin
            Console.WriteLine("Listr fin");
   
            liste.InsererFin(e1);
            liste.Lister();
            

        }
    }
}

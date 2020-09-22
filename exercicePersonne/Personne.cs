using System;
using System.Collections.Generic;
using System.Text;

namespace exercicePersonne
{
    class Personne
    {
        private string nom { get; set; }
        private string prenom { get; set; }
        private int age { get; set; }
        static int nombrePersonne { get; set; }
        public Personne(string nom,string prenom,int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            nombrePersonne++;
        }
        public void afficher()
        {
            Console.WriteLine($"nom:{nom},prenom:{prenom}, age={age}");

        }
        public void Combien()
        {
            Console.WriteLine(nombrePersonne + " personnes ont été crées depuis le début");
        }
    }
}

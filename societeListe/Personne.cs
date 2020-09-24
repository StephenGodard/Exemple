using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Societe
{
    class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }
        static int nombrePersonne { get; set; }
        public Personne(string nom,string prenom,int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            nombrePersonne++;
        }
        public Personne(string nom,string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public override string ToString()
        {
            return $"nom:{nom}, prenom:{prenom}, age:{age}";
        }

        public void afficher()
        {
            Console.WriteLine(this.ToString());
        }
        public void Combien()
        {
            Console.WriteLine(nombrePersonne + " personnes ont été crées depuis le début");
        }
        public static Personne operator ++(Personne personne)
        {
            personne.age += 1;
            return personne;
        }
    }
}

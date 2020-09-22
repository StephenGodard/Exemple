using System;

namespace exercicePersonne
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne a1 = new Personne("Godard", "Stephen", 24);
            a1.afficher();
            a1.Combien();
        }
    }
}

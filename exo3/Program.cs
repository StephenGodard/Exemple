using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("Article 1", 3, 10,Type.alimentaire);
            a1.Afficher();
            a1.Ajouter(5);
            a1.Retirer(2);
            a1.Afficher();
        }
    }
}

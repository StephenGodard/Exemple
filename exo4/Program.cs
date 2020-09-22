using System.Collections.Generic;
using System.Text;
using System;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("Article 1", 3, 10,Type.alimentaire);
            Article a2 = new Article("Article 2", 4, 8, Type.habillement);
            Article a3 = new Article("Article 3", 2, 3, Type.droguerie);
            Article a4 = new Article("Article 4", 9, 12, Type.loisir);
            Article[] tableau = new Article[] { a1, a2, a3, a4 };

          
            Console.WriteLine("nombre d'article:" + tableau.Length);

         for(int i = 0; i < tableau.Length; i++)
            {
                tableau[i].Afficher();
            }

        }
    }
}

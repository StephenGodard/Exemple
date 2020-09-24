using System;
using System.Collections.Generic;
using System.Linq;

namespace linqExo1
{
    class Program
    {
        public static bool NombrePremier(int nombre)
        {
           
            if (nombre == 1)
            {
                return false;
            }
            else if (nombre == 2)
            {
                return true;
            }
            else
            {
                
                int sqrt_nbr = (int)Math.Sqrt(nombre);
                for (int i = 2; i <= sqrt_nbr; i++)
                {
                    if (nombre % i == 0)
                        return false;
                }

                return true;
            }
        }
        public static void Main(string[] args)
        {
            List<int> maListe = new List<int> { 1,2, 3, 4, 5, 6, 7, 8, 9, 10 };



            var queryNbr =
            from nbr in maListe
            where (NombrePremier(nbr)) == true
            select nbr;

            
            foreach (int nbr in queryNbr)
            {
                Console.Write(nbr);
            }
        }
    }
}

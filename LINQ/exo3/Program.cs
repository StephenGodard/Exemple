using System;
using System.Collections.Generic;
using System.Linq;

namespace linqExo1
{
    class Program
    {


        public static void Main(string[] args)
        {
           var maListe = new List<int>() {20,21,22,23,24,25,26,27,28,29,30};

            var division = maListe.Where(num => num % 5 == 0);

            foreach (var num in division)
            {
                Console.WriteLine(num);
            }



        }
    }
}
    


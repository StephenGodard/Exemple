using System;
using System.Collections.Generic;
using System.Linq;

namespace linqExo1
{
    class Program
    {
        public static bool isBissextile(int year)
        {
            var firstDate = new DateTime(year, 1, 1);
            var endDate = new DateTime(year, 12, 31);
            TimeSpan Ts = endDate - firstDate;

            var nbJours = Ts.TotalDays + 1;
            if (nbJours == 366)
                return true;

            return false;
        }

        public static void Main(string[] args)
        {
            List<int> maListe = new List<int> {2012, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };


            var requeteBissextile = from uneAneee in maListe
                                    where isBissextile(uneAneee)
                                    select uneAneee;


            List<int> anneesBissextiles = requeteBissextile.ToList();
            foreach (int annee in anneesBissextiles)
            {
                Console.Write(annee + "\n");
            }
        }




    }
    }


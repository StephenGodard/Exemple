using System;
using System.Collections.Generic;
using System.Text;
using Articlee;
namespace Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            var article = new Article("Nom d'article",29.00);
            article.Acheter();
            var disque = new Disque("Disque",article.Prix,article.Designation);
            disque.ecouter();
            var video = new Video(23.54,article.Prix,article.Designation);
            var livre = new Livre(2846, 33,article.Prix,article.Designation);

           
        
            video.afficher();


        }
    }
}

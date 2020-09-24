using System;
using System.Collections.Generic;
using System.Text;

namespace ListeChainee
{
    public class Liste
    {
        public Element Debut;
        public int NbElement { get; set; }



        public Liste()
    {
        this.Debut = null;
        this.NbElement = 0; ;
    }
    public void InsererDebut(Object objet)
    {
        Element ancienDebut = this.Debut;
            this.Debut = new Element(objet);
            this.Debut.suivant = ancienDebut;
      
        this.NbElement++;
    }
    public void InsererFin(Object objet)
    {
            if (this.Debut == null)
            {
                this.Debut = new Element(objet);
            }
        Element Browse = this.Debut;
        while (Browse.suivant != null)
        {
            Browse = Browse.suivant;
        }
        Browse.suivant = new Element(objet);
        this.NbElement++;

    }
    public void Lister()
    {
        
        Element browse = this.Debut;
        while (browse.suivant != null)
        {
            Console.WriteLine(browse.ToString());
            browse = browse.suivant;
        }
        Console.WriteLine(browse.ToString());
    }
    public void Vider()
    {
       
            this.Debut = null;
            this.NbElement = 0;
        
    }
}


   
}

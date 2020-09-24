using System;
using System.Collections.Generic;
using System.Text;

namespace ListeChainee
{

    class Liste
    {
        public Element Debut;
        public int NbElement;

        public Liste()
        {
            this.Debut = null;
            this.NbElement = 0; ;
        }
        public void InsererDebut(Element objet)
        {
            this.Debut = objet;
        }
        public void InsererFin(Element objet)
        {
            if(Debut.suivant!=null)
            {
                this.Debut = this.Debut.suivant;
                this.Debut.suivant = objet;
            }
        }
        public void Vider()
        {
            while (Debut.suivant != null)
            {
                this.Debut = null;
            }
        }
    }
}

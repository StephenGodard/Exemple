using System;
using System.Collections.Generic;
using System.Text;

namespace ListeChainee
{
    public class Element
    {
        private object Objet { get; set; }
        public Element suivant { get; set; }
        public Element(object obj)
        {
            this.Objet = obj;
            this.suivant = null;
        }
        public override string ToString()
        {
            return $"{Objet}";
        }

    }
}


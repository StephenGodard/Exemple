using System;
using System.Collections.Generic;
using System.Text;

namespace ListeChainee
{
    class Element
    {
        public object Objet { get; set; }
        public Element suivant { get; set; }
        public Element (object obj)
        {
            this.Objet = obj;
        }
    }
}

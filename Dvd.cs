using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Documento
    {
        private int durata;
        public int Durata { get; set; }

        public Dvd(string codice,string titolo,int anno,string settore,string stato,string scaffale,string autore, int durata) : base(codice, titolo, anno, settore, stato, scaffale, autore)
        {
            Durata = durata;
        }
    }
}

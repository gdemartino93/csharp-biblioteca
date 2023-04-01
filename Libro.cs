using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libro : Documento
    {
        private int numPagine;
        public int NumPagine { get; set; }

        public Libro(string codice,string titolo,int anno,string settore,string stato,string scaffale,string autore, int numPagine ) :base(codice,titolo,anno,settore,stato, scaffale, autore)
        {
            NumPagine = numPagine;
        }
    }
}

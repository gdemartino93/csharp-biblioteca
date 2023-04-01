using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public abstract class Documento
    {
        private string codice;
        private string titolo;
        private int anno;
        private string settore;
        private string stato;
        private string scaffale;
        private string autore;

        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public string Stato { get; set; }
        public string Scaffale { get; set; }
        public string Autore { get; set; }

        public Documento(string codice,string titolo,int anno,string settore, string stato,string scaffale,string autore)
        {
            Codice = codice;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Stato = stato;
            Scaffale = scaffale;
            Autore = autore;
        }
    }
}

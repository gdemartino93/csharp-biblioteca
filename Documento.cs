using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {
        private string codice;
        private string titolo;
        private DateTime anno;
        private string settore;
        private string stato;
        private string scaffale;
        private string autore;

        public string Codice { get; set; }
        public string Titolo { get; set; }
        public DateTime Anno { get; set; }
        public string Settore { get; set; }
        public string Stato { get; set; }
        public string Scaffale { get; set; }
        public string Autore { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        private string prestitoDa;
        private string prestitoA;
        private Cliente cliente;
        private Documento documento;

        public string PrestitoDa { get; set; }
        public string PrestitoA { get; set; }
        public Cliente Cliente { get; set; }
        public Documento Documento { get; set; }

        public Prestito(string prestitoDa,string prestitoA,Documento documento, Cliente cliente)
        {
            PrestitoDa = prestitoDa;
            PrestitoA = prestitoA;
            Documento = documento;
            Cliente = cliente;
        }
        public override string ToString()
        {
            return "dal: " + PrestitoDa + " al: " + PrestitoA + "In prestito a: " + Cliente.Nome + " " + Cliente.Cognome + " per " + Documento.Titolo;
        }
    }
}

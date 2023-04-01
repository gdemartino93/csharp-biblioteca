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

        public Libro(int numPagine)
        {
            NumPagine = numPagine;
        }
    }
}

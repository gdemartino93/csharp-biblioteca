using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Cliente
    {
        private string nome;
        private string cognome;
        private string email;
        private string telefono;

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nome,string cognome,string email,string telefono)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Telefono = telefono;
        }
    }
}

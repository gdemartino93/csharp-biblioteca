namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creiamo le liste
            List<Documento> libri = new List<Documento>();
            List <Documento> films = new List<Documento>();
            List<Cliente> clienti = new List<Cliente>();

            Documento libro1 = new Libro("123908", "Harry Potter", 2000, "Fantastico", "Libero", "A1", "Chris col", 200);
            Documento libro2 = new Libro("234567", "Il Signore degli Anelli", 1954, "Fantasy", "Bompiani", "B1", "J.R.R. Tolkien", 1000);
            Documento libro3 = new Libro("345678", "1984", 1949, "Distopia", "Mondadori", "C1", "George Orwell", 350);

            //aggiungiamo i libri alla list
            libri.Add(libro1);
            libri.Add(libro2);
            libri.Add(libro3);

            Documento film1 = new Dvd("1234", "Inception", 2010, "Azione", "Disponibile", "SCAFFALE1", "Christopher Nolan", 148);
            Documento film2 = new Dvd("5678", "Il Signore degli Anelli: Il Ritorno del Re", 2003, "Fantasy", "Disponibile", "SCAFFALE2", "Peter Jackson", 201);
            Documento film3 = new Dvd("9012", "Forrest Gump", 1994, "Drammatico", "Disponibile", "SCAFFALE3", "Robert Zemeckis", 142);

            //aggiungiamo i film alla list
            films.Add(film1);
            films.Add(film2);
            films.Add(film3);

            Cliente cliente1 = new Cliente("MARCO", "Rossi", "asdasdasd@gmail.com", "3209090901");
            Cliente cliente2 = new Cliente("Luca", "Bianchi", "lucabianchi@gmail.com", "3209090923");
            
            //aggiungiamo i clienti alla list
            clienti.Add(cliente1);
            clienti.Add(cliente2);

            //welcome page
            Console.WriteLine("Benvenuto nella libreria. Scegli l'operazione da effettuare");
            Console.WriteLine("[1] Cerca");
            Console.WriteLine("[2] Prendi in prestito");
            Console.WriteLine("[3] Cerca un prestito");


        }
    }
}
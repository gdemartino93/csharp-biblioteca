using System.Reflection.Metadata;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creiamo le liste
            List<Documento> documenti = new List<Documento>();
            List<Cliente> clienti = new List<Cliente>();

            Documento libro1 = new Libro("123908", "Harry Potter", 2000,"fantasy","prestato","3b","asdasdasd",301);
            Documento libro2 = new Libro("234567", "Il Signore degli Anelli", 1954, "Fantasy", "Bompiani", "B1", "J.R.R. Tolkien", 1000);
            Documento libro3 = new Libro("345678", "1984", 1949, "Distopia", "Mondadori", "C1", "George Orwell",230);

            //aggiungiamo i libri alla list
            documenti.Add(libro1);
            documenti.Add(libro2);
            documenti.Add(libro3);

            Documento film1 = new Dvd("1234", "Inception", 2010, "Azione", "Disponibile", "SCAFFALE1", "Christopher Nolan", 148);
            Documento film2 = new Dvd("5678", "Il Signore degli Anelli: Il Ritorno del Re", 2003, "Fantasy", "Disponibile", "SCAFFALE2", "Peter Jackson", 201);
            Documento film3 = new Dvd("9012", "Forrest Gump", 1994, "Drammatico", "Disponibile", "SCAFFALE3", "Robert Zemeckis", 142);

            //aggiungiamo i film alla list
            documenti.Add(film1);
            documenti.Add(film2);
            documenti.Add(film3);

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
            int cercaAltro = 0;
            int scelta = Convert.ToInt32(Console.ReadLine());

            if (scelta == 1)
            {
                Console.WriteLine("[1] Scegli per codice");
                Console.WriteLine("[2] Scegli per titolo");

                scelta = Convert.ToInt32(Console.ReadLine());

                if (scelta == 1) // Se l'utente ha scelto "Cerca per codice"
                {
                    bool trovato = false;

                    do
                    {
                        Console.WriteLine("Inserisci il codice");
                        string codice = Console.ReadLine();

                        foreach (Documento item in documenti)
                        {
                            if (codice.ToLower() == item.Codice.ToLower())
                            {
                                Console.WriteLine($"{item.Codice} - {item.Titolo} Anno: {item.Anno}, Stato: {item.Stato}, Scaffale: {item.Scaffale}, Autore: {item.Autore}");
                                trovato = true; // Imposta la variabile trovato a true
                                break; // Esci dal ciclo foreach perché hai trovato il documento
                            }
                        }

                        if (!trovato) // Se non hai trovato il documento
                        {
                            Console.WriteLine("Nessun elemento trovato");
                        }

                        Console.WriteLine("Vuoi cercare altro?");
                        Console.WriteLine("[1] Si");
                        Console.WriteLine("[2] No");
                        cercaAltro = Convert.ToInt32(Console.ReadLine());

                    } while (cercaAltro == 1); // Continua a cercare finché l'utente vuole cercare ancora
                }
                if (scelta == 2)
                {
                    bool trovato = false;
                    do
                    {
                        Console.WriteLine("Inserisci il titolo");
                        string titolo = Console.ReadLine();

                        foreach (Documento item in documenti)
                        {
                            if (titolo.ToLower() == item.Titolo.ToLower())
                            {
                                Console.WriteLine($"{item.Codice} - {item.Titolo} Anno: {item.Anno}, Stato: {item.Stato}, Scaffale: {item.Scaffale}, Autore: {item.Autore}");
                                if (item is Libro libro)
                                {
                                    Console.WriteLine($"Numero pagine: {libro.NumPagine}");
                                }
                                if (item is Dvd dvd)
                                {
                                    Console.WriteLine($"Durata in minuti: {dvd.Durata}");
                                }
                                trovato = true;
                                break;
                            }
                        }
                        if (trovato == false)
                        {
                            Console.WriteLine("Nessun elemento trovato");
                        }
                        Console.WriteLine("Vuoi cercare altro?");
                        Console.WriteLine("[1] Si");
                        Console.WriteLine("[2] No");
                        cercaAltro = Convert.ToInt32(Console.ReadLine());
                    } while (cercaAltro == 1);
                }
            }
            if (scelta == 2)
            {
                bool trovato = false;
                bool presente  = true;
                Console.WriteLine("-------------------");
                Console.WriteLine("Registra prestito");
                Console.WriteLine("-------------------");

                Console.WriteLine("Inizio prestito");
                string inizioPrestito = Console.ReadLine();
                Console.WriteLine("Fine prestito");
                string finePrestito = Console.ReadLine();
                Console.WriteLine("Inserisci il titolo");
                string titolo = Console.ReadLine();

                Libro libroPrestito = new Libro("", "", 0, "", "", "", "", 0);
                Dvd dvdPrestito = new Dvd("", "", 0, "", "", "", "", 0);

                foreach (Documento item in documenti)
                {
                    if (titolo.ToLower() == item.Titolo.ToLower())
                    {
                        if(item.Stato.ToLower() == "prestato")
                        {
                            presente = false;
                        }
                        else
                        {
                            presente = true;
                        }
                        if (presente)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Il titolo è attualmente fuori per prestito");
                        }
                      
                    }
 }
                }


            }


        }
    }

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento libro1 = new Libro("123908", "Harry Potter", 2000, "Fantastico", "Libero", "A1", "Chris col", 200);
            Documento libro2 = new Libro("234567", "Il Signore degli Anelli", 1954, "Fantasy", "Bompiani", "B1", "J.R.R. Tolkien", 1000);
            Documento libro3 = new Libro("345678", "1984", 1949, "Distopia", "Mondadori", "C1", "George Orwell", 350);

            Documento film1 = new Dvd("1234", "Inception", 2010, "Azione", "Disponibile", "SCAFFALE1", "Christopher Nolan", 148);
            Documento film2 = new Dvd("5678", "Il Signore degli Anelli: Il Ritorno del Re", 2003, "Fantasy", "Disponibile", "SCAFFALE2", "Peter Jackson", 201);
            Documento film3 = new Dvd("9012", "Forrest Gump", 1994, "Drammatico", "Disponibile", "SCAFFALE3", "Robert Zemeckis", 142);



            Cliente cliente1 = new Cliente("MARCO", "Rossi", "asdasdasd@gmail.com", "3209090901");
            Cliente cliente2 = new Cliente("Luca", "Bianchi", "lucabianchi@gmail.com", "3209090923");

        }
    }
}
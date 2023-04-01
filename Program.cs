namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento libro = new Libro("asd", "asd",1990,"settore","disponibieò","scaffale","autore",5);
            Documento dvd = new Dvd("codicedv", "titolodvd", 1993, "settoredvd", "statodv", "scaffdvd", "autodvd", 190);
            Cliente cliente = new Cliente("marco", "rosis", "asdasdasd@gmail.com", "3209090901");
        }
    }
}
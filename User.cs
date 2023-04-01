public class Utente
{
    public string Nome { get; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Utente(string nome, string cognome, string email, string telefono)
    {
       Nome = nome;
        Cognome = cognome;
        Email = email;
        Telefono = telefono;
    }
}
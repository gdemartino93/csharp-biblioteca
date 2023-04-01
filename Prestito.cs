using csharp_biblioteca;

public class Prestito
{
    public string PrestitoDal { get; }
    public string PrestitoAl { get; }
    public Utente Utente { get; set; }

    public Documento Documento { get; set; }
    public Prestito(string prestitoDal, string prestitoAl, Documento documento, Utente utente)
    {
        PrestitoDal = prestitoDal;
        PrestitoAl = prestitoAl;
        Utente = utente;
        Documento = documento;
    }
    public override string ToString()
    {
        return "dal " + PrestitoDal + " al " + PrestitoAl + ". Utente: " + Utente.Cognome + " " + Utente.Nome + ". Documento: " + Documento.Titolo;
    }
}
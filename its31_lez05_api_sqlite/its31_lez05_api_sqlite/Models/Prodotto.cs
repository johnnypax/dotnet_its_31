namespace its31_lez05_api_sqlite.Models
{
    public class Prodotto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public string? Codice { get; set; }
        public string? Descrizione { get; set; }
        public decimal Prezzo { get; set; }
    }
}

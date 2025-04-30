using its31_lez04_api_libri.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

#region Endpoint personalizzati

List<Libro> elenco = new List<Libro>()
{
    new Libro(){ Id = 1, Titolo = "Il signore degli anelli", Autore = "JRRT", Anno = 1927},
    new Libro(){ Id = 2, Titolo = "Le due torri", Autore = "JRRT", Anno = 1927},
    new Libro(){ Id = 3, Titolo = "Il ritorno del re", Autore = "JRRT", Anno = 1927},
};

app.MapGet("/", () => elenco);

app.MapGet("/{varId}", (int varId) =>
{
    Libro? lib = elenco.FirstOrDefault(l => l.Id == varId);
    if (lib is not null)
        return Results.Ok(lib);

    return Results.NotFound();
});

app.MapPost("/", (Libro lib) =>
{
    //Validate l'input

    lib.Id = elenco.Count + 1;
    elenco.Add(lib);
    return Results.Ok();
});

//Aggiungete eliminazione e modifica

#endregion

app.Run();
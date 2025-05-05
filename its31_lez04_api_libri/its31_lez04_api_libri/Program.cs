using its31_lez04_api_libri.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

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
    if (lib.Titolo == "" || lib.Autore == "")
        return Results.BadRequest();

    lib.Id = elenco.Count + 1;
    elenco.Add(lib);
    return Results.Ok();
});

app.MapDelete("/{varId}", (int varId) => {
    Libro? lib = elenco.FirstOrDefault(l => l.Id == varId);
    if (lib is not null)
    {
        elenco.Remove(lib);
        return Results.Ok();
    }

    return Results.NotFound();
});

app.MapPut("/{varId}", (int varId, Libro libNew) =>
{
    if (libNew.Titolo == "" || libNew.Autore == "")
        return Results.BadRequest();

    //Cerco il libro vecchio
    Libro? libOld = elenco.FirstOrDefault(l => l.Id == varId);
    if (libOld is null)
        return Results.NotFound();

    if(libNew.Titolo is not null)
        libOld.Titolo = libNew.Titolo;

    if (libNew.Autore is not null)
        libOld.Autore = libNew.Autore;

    if (libNew.Anno != 0)
        libOld.Anno = libNew.Anno;

    return Results.Ok();

});

#endregion

app.UseCors(builder =>
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
    );

app.Run();
using its31_lez05_api_sqlite.Context;
using its31_lez05_api_sqlite.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

#region Configurazione del database SQL Lite
builder.Services.AddDbContext<NegozioContext>(
        options => options.UseSqlite("Data Source=Negozio.db")
    );

builder.Services.AddCors();
#endregion

var app = builder.Build();

#region Se non esiste il database, crealo!

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<NegozioContext>();
    db.Database.EnsureCreated();
}

app.MapPost("/prodotti", (Prodotto pro, NegozioContext db) =>
{
    db.Prodotti.Add(pro);
    db.SaveChanges();
    return Results.Created();
});

app.MapGet("/prodotti", (NegozioContext db) =>
{
    List<Prodotto> elenco = db.Prodotti.ToList();
    return Results.Ok(elenco);
});

app.MapGet("/prodotti/{varId}", (int varId, NegozioContext db) =>
{
    Prodotto? pro = db.Prodotti.Find(varId);
    if (pro is null)
        return Results.NotFound();

    return Results.Ok(pro);
});

app.MapDelete("/prodotti/{varId}", (int varId, NegozioContext db) =>
{
    Prodotto? pro = db.Prodotti.Find(varId);
    if (pro is null)
        return Results.NotFound();

    db.Prodotti.Remove(pro);
    db.SaveChanges();
    return Results.Ok();
});

#endregion

app.UseCors(builder =>
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
    );

app.Run();

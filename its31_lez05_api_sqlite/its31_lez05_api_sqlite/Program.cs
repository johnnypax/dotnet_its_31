using its31_lez05_api_sqlite.Context;
using its31_lez05_api_sqlite.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

#region Configurazione del database SQL Lite
builder.Services.AddDbContext<NegozioContext>(
        options => options.UseSqlite("Data Source=Negozio.db")
    );
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

#endregion

app.Run();

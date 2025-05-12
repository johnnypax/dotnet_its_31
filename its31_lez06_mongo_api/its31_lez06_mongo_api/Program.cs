

using its31_lez06_mongo_api.Models;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var client = new MongoClient("mongodb://localhost:27017");
var db = client.GetDatabase("Universita");
var collStudenti = db.GetCollection<Studente>("Studenti");

app.MapGet("/studenti", () =>
{
    var elenco = collStudenti.Find(_ => true).ToList();
    return Results.Ok(elenco);
});

app.MapGet("/studenti/{varId}", (string varId) =>
{
    var studente = collStudenti.Find(s => s.Id == varId).ToList();
    if (studente is null)
        return Results.NotFound();

    return Results.Ok(studente);
});

app.MapGet("/studenti/matricola/{varMatr}", (string varMatr) =>
{
    var studente = collStudenti.Find(s => s.Matricola == varMatr).ToList();
    if (studente is null)
        return Results.NotFound();

    return Results.Ok(studente);
});

app.MapPost("/studenti", (Studente stu) =>
{
    try
    {
        collStudenti.InsertOne(stu);
        if (stu.Id is not null)
            return Results.Ok(stu);

        return Results.BadRequest();
    }
    catch (Exception ex)
    {
        return Results.BadRequest();
    }
    
});

app.Run();
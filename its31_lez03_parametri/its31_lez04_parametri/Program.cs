var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

#region Endpoint personalizzati

//Invocazione rapida
app.MapGet("/", () => "Sono la home page dell'applicazione");

//Invocazione standard
app.MapGet("/secondaria", () =>
{
    return "Sono la pagina secondaria";
});

//Passaggio di parametri nei segmenti
app.MapGet("/saluta/{nome}", (string nome) =>
{
    return $"Ciao {nome}";
});

//Overload di Saluta
app.MapGet("/saluta/{nome}/{cognome}", (string nome, string cognome) =>
{
    return $"Salutiamo {nome} {cognome}";
});

//Somma
app.MapGet("/somma", (int a, int b) =>
{
    return a + b;
});

//Ritorno
app.MapGet("/persona/info", () =>
{
    Persona per = new Persona("Giovanni Pace", 38);
    return per;
});

//Creazione di un oggetto
app.MapPost("/persona/inserisci", (Persona per) =>
{
    return $"Ciao, {per.nome}, hai una età di {per.eta}";
});

//Risposta con ritardo
app.MapGet("/conritardo", async () =>
{
    await Task.Delay(3000);
    return "Ciao Giovanni";
});

app.MapGet("/risposte", () =>
{
    return Results.NotFound("Ciao Giovanni");
});

#endregion

app.Run();

record Persona(string nome, int eta);
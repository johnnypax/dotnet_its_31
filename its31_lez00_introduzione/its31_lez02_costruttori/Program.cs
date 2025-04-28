using its31_lez02_costruttori.Models;

Studente val = new()
{
    Nome = "Valeria",
    Cognome = "Verdi"
};
Console.WriteLine(val);

Studente gio = new()
{
    Nome = "Giovanni",
    Cognome = "Pace"
};
Console.WriteLine(gio);

Studente mar = new("Marika", "Mariko");
Console.WriteLine(mar);
//Sono un commento singola linea

/*
 * Sono un commento multilinea
 */

#region Output di nomi
//Console.WriteLine("Giovanni");
//Console.WriteLine("Giovanni");
//Console.WriteLine("Mario");
//Console.WriteLine("Mario");
//Console.WriteLine("Marika");
//Console.WriteLine("Marika");
#endregion 

using its31_lez02_classi.Models;

Persona persona = new Persona();
persona.Nome = "Giovanni";
persona.Cognome = "Pace";
persona.Eta = 38;

//Console.WriteLine(persona.Nome);

Persona val = new()
{
    Nome = "Valeria",
    Cognome = "Verdi",
    Eta = 35
};
using its31_lez05_task.Models;

List<Libro> elenco =  new List<Libro>();

Libro libUno = new()
{
    Autore = "JRRT",
    Titolo = "Il signore degli anelli",
    Anno = 1922,
    IsDisponibile = true,
    Isbn = "AB12345"
};

Libro libDue = new()
{
    Autore = "JRRT",
    Titolo = "Il signore degli anelli: Le due torri",
    Anno = 1922,
    IsDisponibile = true,
    Isbn = "AB12345"
};

elenco.Add(libUno);
elenco.Add(libDue);

for(int i=0; i < elenco.Count; i++)
{
    Console.WriteLine(elenco[i]);
}
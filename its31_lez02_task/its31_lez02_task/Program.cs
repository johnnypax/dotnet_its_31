/*
 * Creare un sistema di controllo di una biblioteca che permetta, tramite un menu, di:
 * 1. Inserire un nuovo libro
 * 2. Stampare tutti i libri
 */

using its31_lez02_task.Models;

List<Libro> elenco = new List<Libro>();
bool insAbi = true;


while (insAbi)
{
    Console.WriteLine("Ciao, scegli cosa vuoi fare:\n" +
        "I - Aggiungi un nuovo libro\n" +
        "S - Stampa tutti i libri\n" +
        "Q - Uscire\n");
    string? input = Console.ReadLine();

    switch (input)
    {
        case "I":
            try
            {
                Console.WriteLine("Autore:");
                string? autore = Console.ReadLine();
                Console.WriteLine("ISBN:");
                string? isbn = Console.ReadLine();
                Console.WriteLine("Anno:");
                string? annoStringa = Console.ReadLine();
                int anno = 0;
                if (annoStringa is not null)
                    anno = Convert.ToInt32(annoStringa);

                Libro lib = new()
                {
                    Anno = anno,
                    Autore = autore,
                    Isbn = isbn,
                };

                elenco.Add(lib);

            } catch {
                Console.Error.WriteLine("Errore nell'operazione");
            }
            break;
        case "S":
            foreach (Libro lib in elenco)
            {
                Console.WriteLine(lib);
            }

            break;
        case "Q":
            insAbi = false;
            break;
        default:
            Console.WriteLine("Comando non riconosciuto\n");
            break;
    }
}

Console.WriteLine("Programma terminato");
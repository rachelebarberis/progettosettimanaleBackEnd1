using progettosettimanaleBackEnd1.Models;

Contribuente contribuente = new Contribuente();

Console.WriteLine("Inserisci il tuo nome: ");
contribuente.Nome = Console.ReadLine();

Console.WriteLine("Inserisci il tuo cognome: ");
contribuente.Cognome = Console.ReadLine();

Console.WriteLine("Inserisci la tua data di nasciata (dd/MM/yyyy): ");
contribuente.DataNascita = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il tuo codice fiscale: ");
contribuente.CodiceFiscale = Console.ReadLine();

Console.WriteLine("Inserisci il tuo sesso (M/F): ");
contribuente.Sesso = char.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il tuo comune di residenza: ");
contribuente.ComuneResidenza = Console.ReadLine();

Console.WriteLine("Inserisci il tuo reddito: ");
contribuente.RedditoAnnuale = decimal.Parse(Console.ReadLine());

contribuente.Riepilogo();
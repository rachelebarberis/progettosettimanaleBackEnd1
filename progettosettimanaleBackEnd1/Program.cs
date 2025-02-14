using progettosettimanaleBackEnd1.Models;

Contribuente contribuente = new Contribuente();

Console.WriteLine("Inserisci il tuo nome: ");
string nome = Console.ReadLine();
while (string.IsNullOrWhiteSpace(nome) || nome.Length <= 2)
{
    Console.WriteLine("Il nome deve avere più di due caratteri. Inserisci di nuovo il tuo nome: ");
    nome = Console.ReadLine();
}
contribuente.Nome = nome;


Console.WriteLine("Inserisci il tuo cognome: ");
contribuente.Cognome = Console.ReadLine();

Console.WriteLine("Inserisci la tua data di nascita (dd/MM/yyyy): ");
DateTime dataNascita;

while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascita))
{
    Console.WriteLine("Formato data non valido. Per favore inserisci la data nel formato dd/MM/yyyy: ");
}

contribuente.DataNascita = dataNascita;

Console.WriteLine("Inserisci il tuo codice fiscale: ");
contribuente.CodiceFiscale = Console.ReadLine();

Console.WriteLine("Inserisci il tuo sesso (M/F): ");
contribuente.Sesso = char.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il tuo comune di residenza: ");
contribuente.ComuneResidenza = Console.ReadLine();

Console.WriteLine("Inserisci il tuo reddito: ");
contribuente.RedditoAnnuale = decimal.Parse(Console.ReadLine());

contribuente.Riepilogo();
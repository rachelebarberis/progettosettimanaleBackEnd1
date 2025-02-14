using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progettosettimanaleBackEnd1.Models
{
    public class Contribuente
    {
        private string _nome;
        private string _cognome;
        private DateTime _dataNascita;
        private string _codiceFiscale;
        private char _sesso;
        private string _comuneResidenza;
        private decimal _redditoAnnuale;

        public string Nome { get { return _nome; } set { _nome = value; } } 
        public string Cognome { get { return _cognome; } set { _cognome = value; } }
        public DateTime DataNascita { get { return _dataNascita; } set {_dataNascita = value; } } 

        public string CodiceFiscale {  get { return _codiceFiscale;}  set { _codiceFiscale = value; } }
        public char Sesso { get { return _sesso; } set { _sesso = value; } }
        public string ComuneResidenza { get { return _comuneResidenza;} set {  _comuneResidenza = value; } }

        public decimal RedditoAnnuale { get { return _redditoAnnuale; } set { _redditoAnnuale = value; } }

        public Contribuente (string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, decimal redditoAnnuale)
        {
            _nome = nome;
            _cognome = cognome;
            _dataNascita = dataNascita;
            _codiceFiscale= codiceFiscale;
            _sesso = sesso;
            _comuneResidenza= comuneResidenza;
            _redditoAnnuale= redditoAnnuale;
        }

        public Contribuente()
        {
        }

        public decimal Calcolo()
        {
            decimal imposta = 0m;
            if (RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23m;
            }
            else if (RedditoAnnuale > 1500 && RedditoAnnuale <= 28000)
            {
                imposta = ((RedditoAnnuale - 15000) * 0.27m) + 3450;
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                imposta = ((RedditoAnnuale - 28000) * 0.38m) + 6960;
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
            {
                imposta = ((RedditoAnnuale - 55000) * 0.41m) + 17220;
            }
            else 
            {
                imposta = ((RedditoAnnuale - 75000) * 0.43m) + 25420;
            }

            return imposta;
        }

        public void Riepilogo()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Calcolo dell' imposta da versare: ");
            Console.WriteLine($"Contribuente: {_nome} {_cognome}");
            Console.WriteLine($"Nato il {_dataNascita: dd/MM/yyyy} ({_sesso})");
            Console.WriteLine($"Residente in {_comuneResidenza}");
            Console.WriteLine($"Codice Fiscale: {_codiceFiscale}");
            Console.WriteLine($"Reddito Dichiarato: {_redditoAnnuale}");
            Console.WriteLine($"Imposta da versare: {Calcolo()}");
        }
    }
}

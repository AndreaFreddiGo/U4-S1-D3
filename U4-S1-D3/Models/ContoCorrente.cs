namespace U4_S1_D3.Models
{
    public class ContoCorrente
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }
        private double Saldo { get; set; } = 0.0;
        private bool NuovoConto { get; set; } = true;

        public ContoCorrente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public void AperturaConto(double importo)
        { if (NuovoConto)
            {
                if (importo <= 1000)
                {
                    Saldo = importo;
                    NuovoConto = false;
                }
                else
                {
                    Saldo = 1000;
                    NuovoConto = false;
                    Console.WriteLine("L'importo massimo per l'apertura del conto è di 1000 euro");

                }
            }
            else { Console.WriteLine("Il conto è già stato aperto"); }
        }

        public void Versamento(double importo)
        {
            if (importo > 0)
            {
                Saldo += importo;
            }
            else
            {
                Console.WriteLine("L'importo deve essere maggiore di 0");
            }
        }

        public void Prelievo(double importo)
        {
            if (importo > 0)
            {
                if (Saldo >= importo)
                {
                    Saldo -= importo;
                }
                else
                {
                    Console.WriteLine("Saldo non sufficiente");
                }
            }
            else
            {
                Console.WriteLine("L'importo deve essere maggiore di 0");
            }
        }

    }
}

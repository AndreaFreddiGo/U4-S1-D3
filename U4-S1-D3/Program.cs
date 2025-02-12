
using U4_S1_D3.Models;


//esercizio 1

ContoCorrente contoCorrente = new ContoCorrente("Mario", "Rossi");

contoCorrente.AperturaConto(500);

contoCorrente.Versamento(200);

contoCorrente.Prelievo(1000);


//esercizio 2

String[] nomi = new String[8] { "Mario", "Luca", "Paolo", "Giovanni", "Andrea", "Giuseppe", "Francesco", "Davide" };

static void EsisteNome(String[] nomi, String nome)
{
    for (int i = 0; i < nomi.Length; i++)
    {
        if (nomi[i] == nome)
        {
            Console.WriteLine($"Il nome {nome} è presente nella lista");
            return;
        }
    }
    Console.WriteLine($"Il nome {nome} non è presente nella lista");
}

EsisteNome(nomi, "Mario");
EsisteNome(nomi, "Luigi");


//esercizio 3

static void Numbers(int dimension)
{
    int[] numbers = new int[dimension];
    Random random = new Random();
    for (int i = 0; i < dimension; i++)
    {
        numbers[i] = random.Next(1, 101);
    }

    Console.WriteLine("Numeri generati: " + string.Join(", ", numbers));
    Console.WriteLine("La somma dei numeri dell'array è: " + numbers.Sum());
    Console.WriteLine("La media dei numeri dell'array è: " + numbers.Average());
}

Numbers(15);


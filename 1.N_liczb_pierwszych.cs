class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int zliczanie = 0;
        int liczba = 2;

        while (zliczanie < n)
        {
            if (sprawdzCzyPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                zliczanie++;
            }

            liczba++;
        }
    }

    static bool sprawdzCzyPierwsza(int liczba)
    {
        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
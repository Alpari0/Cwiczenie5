Random random = new Random();
int iloscLiczbParzystych = 10; // Ilość liczb parzystych do wylosowania
int licznikLosowan = 0; // Licznik losowań

Console.Write("Wersja 2: ");
for (int i = 0; i < iloscLiczbParzystych; i++)
{
    int wylosowanaLiczba = random.Next(-4, 5) * 2;
    licznikLosowan++;

    Console.Write(wylosowanaLiczba);

    if (i < iloscLiczbParzystych - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine();
Console.WriteLine("Liczba wykonanych losowań: " + licznikLosowan);
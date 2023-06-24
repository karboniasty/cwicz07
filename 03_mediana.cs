namespace _03_mediana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random losowa = new Random();
            int rozmiar;
            Console.Write("Podaj rozmiar tablicy: ");
            while(!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar>100)
            {
                Console.Write("Zła wartość. Podaj rozmiar tablicy: ");
            }
            int[] tablica = new int[rozmiar];

            for (int i = 0; i< rozmiar; i++)
            {
                tablica[i] = losowa.Next(100); //przyjmuję takie liczby by było łatwiej sprawdzić poprawność kodu
                Console.Write(tablica[i] + " "); //wypis w celu sprawdzenia
            }

            Console.WriteLine("\nMediana wynosi: " + licz_mediane(tablica, rozmiar));
        }

        static double licz_mediane(int[] tablica, int rozmiar)
        {
            double mediana = tablica[0];
            int mniejsze, wieksze;
            if(rozmiar%2 ==1)
            {
                for (int i = 0; i < rozmiar; i++)
                {
                    mniejsze = 0;
                    wieksze = 0;
                    for (int j = 1; j < rozmiar; j++)
                    {
                        if (tablica[j] > tablica[i])
                            wieksze++;
                        else
                            mniejsze++;
                    }
                    if (mniejsze == wieksze)
                    {
                        mediana = tablica[i];
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < rozmiar; i++)
                {
                    mniejsze = 0;
                    wieksze = 0;
                    for (int j = 1; j < rozmiar; j++)
                    {
                        if (tablica[j] > tablica[i])
                            wieksze++;
                        else
                            mniejsze++;
                    }
                    if (mniejsze -1 == wieksze)
                    {
                        mediana = tablica[i];
                        break;
                    }
                }
                for (int i = 0; i < rozmiar; i++)
                {
                    mniejsze = 0;
                    wieksze = 0;
                    for (int j = 1; j < rozmiar; j++)
                    {
                        if (tablica[j] > tablica[i])
                            wieksze++;
                        else
                            mniejsze++;
                    }
                    if (mniejsze + 1 == wieksze)
                    {
                        mediana = (double)(mediana + tablica[i])/2;
                        break;
                    }
                }
            }
                       
            return mediana;
        }
    }
}
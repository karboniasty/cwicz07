namespace _04_zblizone_wiersze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random losowa = new Random();
            int wiersze, kolumny, wiersz1, wiersz2;
            Console.Write("Podaj liczbę wierszy: ");
            while(!int.TryParse(Console.ReadLine(), out wiersze))
            {
                Console.Write("Zła wartość. Podaj liczbę wierszy: ");
            }
            Console.Write("Podaj liczbę kolumn: ");
            while (!int.TryParse(Console.ReadLine(), out kolumny))
            {
                Console.Write("Zła wartość. Podaj liczbę kolumn: ");
            }
            int[,] tablica= new int[wiersze, kolumny];
            for(int i =0; i< wiersze; i++)
            {
                for(int j =0; j< kolumny; j++)
                {
                    tablica[i,j] = losowa.Next(50); 
                }
            }
            znajdz_wiersze(tablica, out wiersz1, out wiersz2);
            Console.WriteLine("Najbardziej zbliżone do siebie wiersze to: wiersz {0} i wiersz {1}", wiersz1, wiersz2);
        }

        static void znajdz_wiersze(int[,] tablica, out int wiersz1, out int wiersz2)
        {
            int liczba_wierszy = tablica.GetLength(0);
            wiersz1 = 0;
            wiersz2=1;
            double wynik = double.MaxValue, pomocniczy;
            for (int i=0; i<liczba_wierszy; i++)
            {                
                for(int j=i+1; j<liczba_wierszy; j++)
                {
                    pomocniczy = oblicz_zroznicowanie(tablica, i, j);
                    if (pomocniczy < wynik)
                    {
                        wynik = pomocniczy;
                        wiersz1 = i;
                        wiersz2 = j;
                    }
                    
                }
            }
        }

        static double oblicz_zroznicowanie(int[,] tablica, int wiersz1, int wiersz2)
        {
            double wynik=0;
            int liczba_kolumn = tablica.GetLength(1);
            for (int i=0;i<liczba_kolumn;i++)
            {
                wynik += Math.Pow(tablica[wiersz1, i] - tablica[wiersz2, i], 2);
            }
            return wynik;
        }
    }
}
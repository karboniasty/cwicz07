namespace _06_srednia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rozmiar;
            Random losowa = new Random();
            Console.Write("Podaj rozmiar tablicy: ");
            while (!int.TryParse(Console.ReadLine(), out rozmiar))
            {
                Console.Write("Zła Wartość. Podaj rozmiar tablicy: ");
            }
            double[] tablica = new double[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                tablica[i] = Math.Round(losowa.NextDouble() * 100, 2);                
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine("\nŚrednia arytmetyczna tych liczb wynosi: " + Math.Round(licz_srednia(tablica, rozmiar), 2));
            //dokładność podaję dla łatwiejszego sprawdzenia kodu
        }

        static double licz_srednia(double[] tablica, int rozmiar)
        {
            if(rozmiar==2)
            {
                return (tablica[0] + tablica[1])/2;
            }            
            return ((rozmiar-1)*licz_srednia(tablica, rozmiar - 1) + tablica[rozmiar - 1]) / rozmiar;
        }
    }
}
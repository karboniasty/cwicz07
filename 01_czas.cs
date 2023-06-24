namespace _01_czas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int czas;
            Console.Write("Podaj czas, jaki upłynął od godziny 00:00:00 (w sekundach): ");
            while(!int.TryParse(Console.ReadLine(), out czas) || czas<0)
            {
                Console.Write("Zła wartość. Podaj czas: ");
            }
            wypisz_czas(czas);
        }

        static void wypisz_czas(int czas)
        {
            int godziny = czas/3600, minuty = (czas%3600)/60, sekundy = czas%60;
            if (godziny >= 24)
                godziny %= 24;
            if (godziny < 10)
                Console.Write("0{0}:", godziny);
            else
                Console.Write(godziny + ":");
            if (minuty < 10)
                Console.Write("0{0}:", minuty);
            else
                Console.Write(minuty + ":");
            if (sekundy < 10)
                Console.Write("0{0}", sekundy);
            else
                Console.Write(sekundy);
            return;
        }
    }
}
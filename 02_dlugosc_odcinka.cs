namespace _02_dlugosc_odcinka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            Console.Write("Podaj pierwszą współrzędną pierwszego punktu: ");
            while(!double.TryParse(Console.ReadLine(), out x1))
                Console.Write("Zła Wartość. Podaj pierwszą współrzędną pierwszego punktu: ");
            Console.Write("Podaj drugą współrzędną pierwszego punktu: ");
            while (!double.TryParse(Console.ReadLine(), out y1))
                Console.Write("Zła Wartość. Podaj drugą współrzędną pierwszego punktu: ");
            Console.Write("Podaj pierwszą współrzędną drugiego punktu: ");
            while (!double.TryParse(Console.ReadLine(), out x2))
                Console.Write("Zła Wartość. Podaj pierwszą współrzędną drugiego punktu: ");
            Console.Write("Podaj drugą współrzędną drugiego punktu: ");
            while (!double.TryParse(Console.ReadLine(), out y2))
                Console.Write("Zła Wartość. Podaj drugą współrzędną drugiego punktu: ");
                        
            Console.WriteLine("Długość tego odcinka wynosi: " + licz_dlugosc(x1, y1, x2, y2));
        }

        static double licz_dlugosc(double x1, double y1, double x2, double y2)
        {
            double dlugosc= Math.Sqrt(Math.Pow(x1-x2,2) + (Math.Pow(y1-y2,2)));            
            return dlugosc;
        }
    }
}
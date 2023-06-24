namespace _05_dzielniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            Console.Write("Podaj liczbę naturalną: ");
            while(!int.TryParse(Console.ReadLine(), out liczba) )
            {
                Console.Write("Zła wartość. Podaj liczbę naturalną: ");
            }
            Console.WriteLine("Liczba dzielników, które są liczbami pierwszymi, tej liczby wynosi: " + licz_dzielniki(liczba));
        }
        
        static int licz_dzielniki (int liczba)
        {
            if (liczba <= 5)
                return 0;
            int dzielniki=0;
            bool czy_pierwsza;            
            for(int i=2; i<=liczba; i++)
            {
                if(liczba%i==0)
                {
                    double pierwiastek = Math.Sqrt(i);
                    czy_pierwsza = true;                    
                    for (int j =2; j<=pierwiastek;j++)
                    {                        
                        if (i%j==0)
                        {
                            
                            czy_pierwsza = false;
                            break;
                        }
                    }
                    if (czy_pierwsza)
                        dzielniki++;
                }
                
            }
            return dzielniki;
        }
    }
}
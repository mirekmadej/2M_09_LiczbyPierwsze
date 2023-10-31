namespace _2M_09_LiczbyPierwsze
{
    class LiczbaPierwsza
    {
        const int N = 1000;
        private int[] liczby = new int[N + 1] ;
        public LiczbaPierwsza()
        {
            generujTablice();
        }
        private void generujTablice()
        {
            for(int i = 0; i <=N ; i++)
                liczby[i] = 1;
            liczby[0] = liczby[1] = 0;
            for(int i = 2; i <=N ; i++)
            {
                if (liczby[i] == 1)
                    for (int j = 2; j <= N/i; j++)
                        liczby[i * j] = 0;
            }
        
        }
        public int czyPierwsza(int n)
        {
            if (n < 0 || n > N) return -1;
            return liczby[n];
        }
        
    }

    class LiczbaPierwsza2
    {
        const int N = 1000;
        private int[] liczby = new int[N];
        public LiczbaPierwsza2()
        {
            utworzTablice();
        }
        private void utworzTablice()
        {
            liczby[0] = -1;
            int licznik = 1;
            LiczbaPierwsza lp = new LiczbaPierwsza();
            for (int i = 0; i < N; i++)
            {
                int x = lp.czyPierwsza(i);
                if (x == 1)
                    liczby[licznik++] = i;
            }


        }
        public int ktoraPierwsza(int n)
        {
            if (n < 0 || n > N) return -1;
            return liczby[n];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            LiczbaPierwsza lp = new LiczbaPierwsza();
            int wynik = lp.czyPierwsza(191);
            if (wynik == -1)
                Console.WriteLine("poza zakresem");
            else if (wynik == 1) 
                Console.WriteLine("pierwsza");
            else
                Console.WriteLine("nie pierwsza");
            Console.WriteLine("liczby pierwsze mniejsze od 100");
            for (int i = 0; i <= 100; i++)
                if (lp.czyPierwsza(i) == 1)
                    Console.Write($"{i}, ");
            Console.WriteLine();

            int ile = 0;
            for (int i = 0; i <= 1000; i++)
                if (lp.czyPierwsza(i) == 1)
                    ile++;
            Console.WriteLine($"liczb pierwszych w przedziale [0, 1000] jest {ile}");

            
        }
    }
}
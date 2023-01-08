namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int i = 0;
            int o = 0;
            for (int contador = 0; contador < x; contador++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 10 && n <= 20)
                {
                    i++;
                }
                else
                {
                    o++;
                }
            }
            Console.WriteLine($"{i} in");
            Console.WriteLine($"{o} out");
        }
    }
}

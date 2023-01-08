namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Pede para o usuário digitar o número e imprime seus divisores
             */
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Pede para o usuário digitar um número, imprimindo na tela todos os números ímpares até o número digitado 
            */
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
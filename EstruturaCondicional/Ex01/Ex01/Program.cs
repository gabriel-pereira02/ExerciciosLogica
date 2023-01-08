namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Pede para o usuário digitar dois números e verifica se eles são múltiplos
             */
            string[] numeros = Console.ReadLine().Split();
            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);
            if(num1%num2 == 0 || num2%num1 == 0)
            {
                Console.WriteLine("Múltiplos");
            }
            else
            {
                Console.WriteLine("Não Múltiplos");
            }
        }
    }
}
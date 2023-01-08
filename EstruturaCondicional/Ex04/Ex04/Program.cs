namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Pede para o usuário digitar um número e mostra na tela o intervalo que ele está 
            */
            float numero = float.Parse(Console.ReadLine());
            if(numero >= 0 && numero <= 25)
            {
                Console.WriteLine("Intervalo: [0, 25]");
            } 
            else if (numero > 25 && numero <= 50)
            {
                Console.WriteLine("Intervalo: (25, 50]");
            }
            else if(numero > 50 && numero <= 75)
            {
                Console.WriteLine("Intervalo: (50, 75]");
            }
            else if(numero > 75 && numero <= 100)
            {
                Console.WriteLine("Intervalo: (75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
namespace Ex001{
    class Program{
        static void Main(string[] args){
            Console.Write("Quantos números inteiros você vai digitar = ");
            int vezes = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= vezes; i++)
            {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
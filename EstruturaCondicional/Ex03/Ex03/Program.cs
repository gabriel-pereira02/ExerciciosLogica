namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Calcula o preço total de produtos pedidos pelo usuário
             */
            string[] produtos = Console.ReadLine().Split();
            int codigo = int.Parse(produtos[0]);
            int quantidade = int.Parse(produtos[1]);
            float total = 0;

            switch(codigo)
            {
                case 1:
                    total = quantidade * 4;
                    break;
                case 2:
                    total = quantidade * 4.50f;
                    break;
                case 3:
                    total = quantidade * 5;
                    break;
                case 4:
                    total = quantidade * 2;
                    break;
                case 5:
                    total = quantidade * 1.50f;
                    break;
            }
            Console.WriteLine($"TOTAL: R${total.ToString("F2")}");
        }
    }
}
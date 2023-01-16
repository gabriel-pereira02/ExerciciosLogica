namespace MediaPrecosProdutos
{
    class Program{
        static void Main(string[] args){
            int qtdProdutos = int.Parse(Console.ReadLine());
            Produto[] produtos = new Produto[qtdProdutos];
            double soma = 0;
            for(int i = 0; i < qtdProdutos; i++){
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preco do produto: ");
                double preco = double.Parse(Console.ReadLine());
                produtos[i]= new Produto(nome, preco);

                soma += produtos[i].Preco;
            }

            double media = soma/qtdProdutos;
            Console.WriteLine($"Média de preço produtos = {media}");
        }
    }
}
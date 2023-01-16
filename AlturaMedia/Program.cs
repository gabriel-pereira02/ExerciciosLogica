namespace AlturaMedia
{
    class Program{
        static void Main(string[] args){
            int numPessoas = int.Parse(Console.ReadLine());
            double[] alturas = new double[numPessoas];
            for(int i = 0; i < numPessoas; i++){
                double altura = double.Parse(Console.ReadLine());
                alturas[i] = altura;
            }

            double mediaAltura = (alturas.Sum())/numPessoas;
            Console.WriteLine($"Altura média: {mediaAltura.ToString("F2")}");
        }
    }
}
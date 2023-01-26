namespace MatrizEx01{
    class Program{
        static void Main(string[] args){
            Console.Write("Digite a ordem da matriz: ");
            int ordem = int.Parse(Console.ReadLine());
            double[,] mat = new double[ordem, ordem];
            int numNeg = 0;
            string diag = "";
            for(int i = 0; i < mat.GetLength(0); i++){
                for(int o = 0; o < mat.GetLength(1); o++){
                    Console.Write($"Digite o valor [{i}, {o}]: ");
                    mat[i, o] = double.Parse(Console.ReadLine());
                    if(mat[i, o] < 0){
                        numNeg++;
                    }

                    if(i == o){
                        diag += $"{mat[i,o].ToString()} ";
                    }
                     
                }
            }

            Console.WriteLine($"Diagonal Principal: {diag}, números negativos na matriz: {numNeg}");

        }
    }
}

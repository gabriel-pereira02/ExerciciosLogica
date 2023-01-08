

namespace Functions
{
    class Program
    {
        static float MontanteJurosSimples(float capital, float juros, float tempo)
        {
            float montante = capital * juros/100 * tempo;
            return montante;
        }

        static double MontanteJurosCompostos(float capital, float juros, float tempo)
        {
            double montante = capital * Math.Pow((1+juros/100), tempo);
            return montante;
        }

        static void Main(string[] args)
        {
            Console.Write("Capital investido: ");
            float capital = float.Parse(Console.ReadLine());
            Console.Write("Quantidade de juros por mês: ");
            float juros = float.Parse(Console.ReadLine());
            Console.Write("Tempo em meses: ");
            float tempo = float.Parse(Console.ReadLine());

            Console.WriteLine("[1] Simples   [2] Composto");
            int opt = int.Parse(Console.ReadLine());
            if(opt == 1)
            {
                Console.WriteLine($"Montante por juros simples: {MontanteJurosSimples(capital, juros, tempo).ToString("F2")}");
            }
            else
            {
                Console.WriteLine($"Montante por juros compostos: {MontanteJurosCompostos(capital, juros, tempo).ToString("F2")}");
            }
        }
    }
}
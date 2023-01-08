namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int diesel = 0;
            int gasolina = 0;
            int opt = int.Parse(Console.ReadLine());
            while (opt != 4)
            {
                if (opt == 1)
                {
                    alcool++;
                }
                else if (opt == 2)
                {
                    gasolina++;
                }
                else if (opt == 3)
                {
                    diesel++;
                }

                opt = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");

        }
    }
}
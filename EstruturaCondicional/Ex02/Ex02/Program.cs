namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Pede ao usuário uma coordenada qualquer e imprime na tela o quadrande que esse ponto está no plano cartesiano
             */
            string[] coord = Console.ReadLine().Split();
            float coordX = float.Parse(coord[0]);
            float coordY = float.Parse(coord[1]);
            if (coordX == 0 && coordY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (coordX == 0 && coordY != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if(coordX != 0 && coordY == 0) 
            {
                Console.WriteLine("Eixo X");
            }
            else if(coordX > 0 && coordY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (coordX > 0 && coordY < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (coordX < 0 && coordY > 0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("Q3");
            }
        }
    }
}
namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Calcula a média ponderada entre três números 
            */
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                float a = float.Parse(arr[0]);
                float b = float.Parse(arr[1]);
                float c = float.Parse(arr[2]);

                float resultado = (a * 2 + b * 3 + c * 5)/10;
                Console.WriteLine($"{resultado}");
            }
        }
    }
}
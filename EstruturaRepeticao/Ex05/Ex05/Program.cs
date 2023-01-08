namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                float n1 = int.Parse(arr[0]);
                float n2 = int.Parse(arr[1]);
                if(n2 == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    Console.WriteLine((n1 / n2).ToString("F2"));
                }
            }
        }
    }
}
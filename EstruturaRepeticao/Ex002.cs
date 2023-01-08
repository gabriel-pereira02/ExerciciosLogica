namespace Ex002{
    class Program{
        static void Main(string[] args){
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
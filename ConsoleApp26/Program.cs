namespace ConsoleApp26
{ // Yeni 1 versek 1, 4 versek 1,2,3,4 yazsin
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("mektebli sayi  n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}-ci məktəbli: {i}");
            }
        }
    }
}

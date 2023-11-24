namespace JedlikRPG
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nyomj bármely számot a kezdéshez: ");
            int nehezseg = Convert.ToInt32(Console.ReadLine());
            Nehezseg(nehezseg);
        }
    }
}
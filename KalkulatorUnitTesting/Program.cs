namespace KalkulatorUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kalkulator = new Kalkulator();
            Console.WriteLine(kalkulator.Divider(8, 0));
        }
    }
}

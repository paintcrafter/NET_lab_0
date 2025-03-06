namespace NET_lab_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            FizzBuzz test = new FizzBuzz(20);
            test.fizz();
        }
    }

    class FizzBuzz
    {
        private int zakres;
        public FizzBuzz(int zakres)
        {
            this.zakres = zakres;
        }
        public void fizz()
        {
            for (int i = 1; i <=zakres; i++)
            {
                if (i%3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

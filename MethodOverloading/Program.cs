namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x,  int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool what)
        {
            if (what)
            {
                if (x + y == -1)
                    return "-1 dollar";
                else if (x + y == 1)
                    return "1 dollar";
                else
                    return (x + y + " dollars");
            }
            else
            {
                return (x+y + " pesos");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,3));
            Console.WriteLine(Add(3.90m, 7.62m));
            Console.WriteLine(Add(2,3,true));
        }
    }
}

using System;

namespace ShortLongShort
{
    class Program
    {
        static void Main(string[] args)
        {
            Mixed mixed = new Mixed();
            string first, second;
            try
            {
                Set(out first, out second);
                ResultMethod(mixed, first, second);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private static void ResultMethod(Mixed mixed, string first, string second)
        {
            string result = mixed.ShortlongShort(first, second);
            Console.WriteLine("Результат: {0}",result);
        }

        private static void Set(out string first, out string second)
        {
            Console.WriteLine("Введите первую строку:");
            first = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            second = Console.ReadLine();
        }
    }
}

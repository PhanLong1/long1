using System;
namespace ktsonguyento
{
    class Program
    {
        public int Nguyento(int number)
        {
            int n = 0;
            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    n++;
            if (n == 2)
                Console.WriteLine("{0} la so nguyen to.", number);
            else
                Console.WriteLine("{0} khong phai la so nguyen to.", number);
            return number;
        }
        static void Main(string[] args)
        {
            int number;
            int result;
            Console.Write("Nhap mot so bat ky: ");
            number = Convert.ToInt32(Console.ReadLine());
            Program n = new Program();
            result = n.Nguyento(number);


        }
    }
}
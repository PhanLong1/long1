using System;

namespace tinhtienlai
{
    class Program
    {
        static void tinh(){
             //Khai báo 3 biến để lưu thông tin về tiền gửi, tháng gửi, tỉ lệ lãi suất
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;

            //Nhận số tiền gửi
            Console.WriteLine("Enter investment amount: ");
            money = Double.Parse(Console.ReadLine());

            //Nhận số tháng gửi
            Console.WriteLine("Enter number of months: ");
            month = Int32.Parse(Console.ReadLine());

            //Nhận lãi suất
            Console.WriteLine("Enter annual interest rate in percentage: ");
            intersetRate = Double.Parse(Console.ReadLine());

            //Tính lãi suất nhận được
             double totalInterset = 0;
            for(int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate/100)/12 * 3; 
            }
            //In ra lãi suất
            Console.WriteLine("Total of interset: " + totalInterset);
        }
        static void Main(string[] args)
        {
            tinh();
        }
    }
}
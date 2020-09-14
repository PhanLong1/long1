using System;
using System.Text;
namespace tinhsongaytrongthang
{
    class Program
    {

        static void tinh(){
Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tháng : ");
            string Sthang = Console.ReadLine();
            int th = int.Parse(Sthang);
            int songay = 0;

            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;
                    case 2: break;

                }
                if (th == 2)
                {
                    Console.Write("=> Tháng " + th + " có 28 hoặc 29 ngày\n");
                }
                else
                Console.Write("=> Tháng " + th + " có " + songay + " ngày\n");
            }
            else
                Console.Write("=> Tháng không hợp lệ!\n");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            tinh();
        }
    }
}
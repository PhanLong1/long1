using System;

namespace kiemtranamnhuan
{
    class Program
    {
        static void namnhuan(){
             int chk_year;

            //in ra cac cau tren mang hinh
            Console.Write("\n\n");
            Console.Write("Kiem tra nam nhuan :\n");
            Console.Write("-----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot nam bat ky de kiem tra: ");

            //nhan gia tri do nguoi dung nhap vao va sau do convert qua kieu int
            chk_year = Convert.ToInt32(Console.ReadLine());

            if((chk_year % 400) == 0)
            {
                Console.WriteLine("{o} la nam nhuan.\n", chk_year);
            } else{
                if((chk_year % 100) == 0){
                    Console.WriteLine("{0} khong phai nam nhuan.\n", chk_year);
                } else{
                    if((chk_year % 4) == 0){
                        Console.WriteLine("{0} la nam nhuan.\n", chk_year);
                    }else{
                        Console.WriteLine("{0} khong phai nam nhuan.\n", chk_year);
                    }
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            namnhuan();
            Console.ReadKey();
        }
    }
}
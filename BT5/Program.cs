using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanlycd = new QuanLyCD();
            int chon = 0;
            do
            {
                Console.WriteLine("***********Chuong trinh quan ly***********");
                Console.WriteLine("1.Them CD");
                Console.WriteLine("2.Tinh gia thanh trung binh");
                Console.WriteLine("3.Sap xep CD giam dan theo gia thanh");
                Console.WriteLine("4.Sap xep CD tang dan theo tua CD");
                Console.WriteLine("5.Xuat toan bo CD");
                Console.WriteLine("0.Thoat chuong trinh.");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Ban chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD: ");
                        cd.macd = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD: ");
                        cd.tuaCD = Console.ReadLine();
                        Console.Write("Nhap ca si: ");
                        cd.Casi = Console.ReadLine();
                        Console.Write("Nhap so bai hat: ");
                        cd.sobaihat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia thanh: ");
                        cd.giathanh = int.Parse(Console.ReadLine());
                        quanlycd.themCD(cd);
                        break;
                    case 2:
                        double kq = quanlycd.TinhTB();
                        Console.WriteLine("Gia thanh trung binh la:{0:#,##0.00}",kq);
                        break;
                    case 3:
                        quanlycd.SapXepTheoGiaThanh();
                        Console.WriteLine("Da sap xep theo gia thanh giam dan roi nha");
                        break;
                    case 4:
                        quanlycd.SapXepTheoTuaCD();
                        Console.WriteLine("Da sap xep theo tua Cd tang dan roi nha");
                        break;
                    case 5:
                        quanlycd.Xuat();
                        break;
                    case 0:
                        Console.WriteLine("Hen gap lai.");
                        Console.ReadLine();
                        break;
                }
            } while (chon != 0);
        }
    }
}

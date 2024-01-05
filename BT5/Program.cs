using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanLyCD = new QuanLyCD();
            int chon = 0;
            do
            {
                Console.WriteLine("**********************Chuong Trinh Quan Ly CD****************");
                Console.WriteLine("1. ThemCD");
                Console.WriteLine("2. Tinh gia thanh trung binh");
                Console.WriteLine("3. Sap xep CD giam dan theo gia thanh");
                Console.WriteLine("4. Sap xep CD tang dan theo gia thanh");
                Console.WriteLine("5. Xaut toan bo CD");
                Console.WriteLine("0. Thoat chuong trinh.");
                Console.WriteLine("-------------------------------------------------------------");
                Console.Write("Ban chon:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma cd:");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD:");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("Nhap ca si:");
                        cd.Casi = Console.ReadLine();
                        Console.Write("Nhap so bai hat:");
                        cd.SoBaiHat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia thanh:");
                        cd.DonGia = int.Parse(Console.ReadLine());
                        quanLyCD.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanLyCD.tinhGiaTB();
                        Console.WriteLine("Gia thanh trung binh : {0:#,##0.00}", kq);
                        break;
                    case 3:
                        quanLyCD.SapXepGiamTheoGiaThanh();
                        Console.WriteLine("Da sap them theo gia thanh giam dan");
                        break;
                    case 4:
                        break;
                    case 5:
                        quanLyCD.Xuat();
                        break;
                    case 0:
                        Console.WriteLine("Tam biet. Hen gap lai!");
                        Console.ReadLine();
                        break;
                }
            } while (chon != 0);
        }
    }
}
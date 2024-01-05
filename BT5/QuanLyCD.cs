using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;
        //phuong thuc constructor
        public QuanLyCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        //Cac phuong thuc tinh toan
        public void ThemCD(CD cd)
        {
            if (n >= ds.Length)
            {
                Console.WriteLine("Danh sach da day");
            }
            else
            {
                if (!kiemTraTrungCD(cd.MaCD))
                    ds[n++] = cd;
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }
        }
        private bool kiemTraTrungCD(int macd)
        {
            for (int i = 0; i < n; i++)
            {
                if (ds[i].MaCD == macd)
                {
                    return true;
                }
            }
            return false;
        }

        public double tinhGiaTB()
        {
            int tonggia = 0;
            for (int i = 0; i < n; i++)
            {
                tonggia += ds[i].DonGia;
            }
            return (double)tonggia / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0, -10} {1,30} {2,30} {3,10} {4,15}",
                "MaCD", "TuaCD", "Ca si", "So bai hat", "Gia thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
        public void SapXepGiamTheoGiaThanh()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].DonGia < ds[j].DonGia)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
    }
}
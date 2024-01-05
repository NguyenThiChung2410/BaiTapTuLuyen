using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;

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
        public void themCD(CD cd)
        {
            if (n >= ds.Length)
            {
                Console.WriteLine("Danh sach da day.");
            }
            else
            {
                if(!KiemtratrungCD(cd.macd))
                {
                    ds[n++] = cd;
                }
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }
        }
        private bool KiemtratrungCD(int MaCD)
        {
            for(int i = 0; i < n; i++)
            {
                if (ds[i].macd == MaCD)
                {
                    return true;
                }
                
            }
            return false;
        }
        public double TinhTB()
        {
            int tonggia = 0;
            for(int i = 0; i < n; i++)
            {
                tonggia += ds[i].giathanh;
            }
            return (double)tonggia / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0,20} {1,30} {2,25} {3,20} {4,20}", "macd", "tuaCD", "casi", "sobaihat", "giathanh");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
        public void SapXepTheoGiaThanh()
        {
            CD temp;
            for(int i = 0; i < n-1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (ds[i].giathanh < ds[j].giathanh)
                    {
                        temp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = temp;
                    }
                }
            }
        }
        public void SapXepTheoTuaCD()
        {
            CD temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].tuaCD.CompareTo(ds[i].tuaCD) > 0) ;
                    {
                        temp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = temp;
                    }
                }
            }



        }
    }
}

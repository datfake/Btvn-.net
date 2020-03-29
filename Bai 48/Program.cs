using System;
using System.Collections.Generic;

namespace Bai_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> list = new List<SinhVien>();
        Menu:
            Console.Clear();
            Console.WriteLine("1. Them Sinh Vien");
            Console.WriteLine("2. Danh sach Sinh Vien");
            Console.WriteLine("3. Tim sinh vien theo mssv");
            Console.WriteLine("4. Xoa Sinh vien theo mssv");
            Console.WriteLine("5. Update SInh vien theo mssv");
            Console.WriteLine("6. Exit");
            Console.Write("Ban hay lua chon 1 so: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    Console.WriteLine("Nhap mssv: ");
                    String mssv = Console.ReadLine();
                    Console.WriteLine("Nhap ten: ");
                    String ten = Console.ReadLine();
                    Console.WriteLine("Nhap khoa: ");
                    String khoa = Console.ReadLine();
                    Console.WriteLine("Nhap diemTB: ");
                    float diemTb = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap diemRL: ");
                    float diemRL = float.Parse(Console.ReadLine());
                    SinhVien sv = new SinhVien(mssv, ten, khoa, diemTb, diemRL);
                    list.Add(sv);
                    goto Menu;
                case "2":
                    Console.WriteLine("Danh Sach Sinh Vien\n---------------------\n");
                    foreach (SinhVien s1 in list)
                    {
                        s1.Xuat();
                    }
                    Console.ReadLine();
                    goto Menu;
                case "3":
                    Console.WriteLine("nhap mssv sinh vien muon tim :");
                    string ms = Console.ReadLine();
                    foreach (SinhVien s2 in list)
                    {
                        if (s2.getMSSV() == ms)
                        {
                            s2.Xuat();
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "4":
                    Console.WriteLine("nhap mssv sinh vien muon xoa :");
                    string msdel = Console.ReadLine();
                    for (int i= 0 ;i <list.Count; i++)
                    {
                        if (list[i].getMSSV() == msdel)
                        {
                            list.RemoveAt(i);
                            Console.WriteLine("Da xoa");
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "5":
                    Console.WriteLine("nhap mssv sinh vien muon xoa :");
                    string msupdate = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].getMSSV() == msupdate)
                        {
                            Console.WriteLine("Nhap mssv: ");
                            String mssv1 = Console.ReadLine();
                            Console.WriteLine("Nhap ten: ");
                            String ten1 = Console.ReadLine();
                            Console.WriteLine("Nhap khoa: ");
                            String khoa1 = Console.ReadLine();
                            Console.WriteLine("Nhap diemTB: ");
                            float diemTb1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap diemRL: ");
                            float diemRL1 = float.Parse(Console.ReadLine());
                            SinhVien sv1 = new SinhVien(mssv1, ten1, khoa1, diemTb1, diemRL1);
                            list[i] = sv1 ;
                            Console.WriteLine("Da update");
                        }
                    }
                    Console.ReadLine();
                    goto Menu;

                case "6":
                    break;

                default:
                    Console.WriteLine("Nhap sai so, chi nhan cac gia tri tu 1-5");
                    Console.ReadLine();
                    goto Menu;
            }

        }
    }
}

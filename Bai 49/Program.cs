using System;
using System.Collections.Generic;

namespace Bai_49
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> list = new List<Question>();
        Menu:
            Console.Clear();
            Console.WriteLine("1. Them Question");
            Console.WriteLine("2. Danh sach question");
            Console.WriteLine("3. Tim cau hoi theo id");
            Console.WriteLine("4. Xoa cau hoi theo id");
            Console.WriteLine("5. Update cau hoi theo id");
            Console.WriteLine("6. Exit");
            Console.Write("Ban hay lua chon 1 so: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    Console.WriteLine("Nhap id: ");
                    String id = Console.ReadLine();
                    Console.WriteLine("Nhap cau hoi: ");
                    String content = Console.ReadLine();
                    Console.WriteLine("Nhap cau tl 1: ");
                    String ques1 = Console.ReadLine();
                    Console.WriteLine("Nhap cau tl 2: ");
                    String ques2 = Console.ReadLine();
                    Console.WriteLine("Nhap cau tl 3: ");
                    String ques3 = Console.ReadLine();
                    Console.WriteLine("Dap an: ");
                    String correct = Console.ReadLine();
                    Console.WriteLine("Nhap thoi gian: ");
                    String time = Console.ReadLine();
                    Question sv = new Question(id, content, ques1, ques2, ques3,correct,time);
                    list.Add(sv);
                    goto Menu;
                case "2":
                    Console.WriteLine("Danh Sach Sinh Vien\n---------------------\n");
                    foreach (Question s1 in list)
                    {
                        s1.Xuat();
                    }
                    Console.ReadLine();
                    goto Menu;
                case "3":
                    Console.WriteLine("nhap id cau hoi muon tim :");
                    string ms = Console.ReadLine();
                    foreach (Question s2 in list)
                    {
                        if (s2.getId() == ms)
                        {
                            s2.Xuat();
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "4":
                    Console.WriteLine("nhap id cau hoi muon xoa :");
                    string msdel = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].getId() == msdel)
                        {
                            list.RemoveAt(i);
                            Console.WriteLine("Da xoa");
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "5":
                    Console.WriteLine("nhap id cau hoi muon xoa :");
                    string msupdate = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].getId() == msupdate)
                        {
                            Console.WriteLine("Nhap id: ");
                            String id1 = Console.ReadLine();
                            Console.WriteLine("Nhap cau hoi: ");
                            String content1 = Console.ReadLine();
                            Console.WriteLine("Nhap cau tl 1: ");
                            String ques11 = Console.ReadLine();
                            Console.WriteLine("Nhap cau tl 2: ");
                            String ques21 = Console.ReadLine();
                            Console.WriteLine("Nhap cau tl 3: ");
                            String ques31 = Console.ReadLine();
                            Console.WriteLine("Dap an: ");
                            String correct1 = Console.ReadLine();
                            Console.WriteLine("Nhap thoi gian: ");
                            String time1 = Console.ReadLine();
                            Question sv1 = new Question(id1, content1, ques11, ques21, ques31, correct1, time1);
                            list[i] = sv1;
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

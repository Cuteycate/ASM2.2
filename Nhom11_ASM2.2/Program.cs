using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_ASM2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cars> listc = new List<Cars>();
            List<Van> listv = new List<Van>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("==========MENU===========");
                Console.WriteLine("1.   Them xe oto");
                Console.WriteLine("2.   Them xe tai");
                Console.WriteLine("3.   Xuat Danh sach ca hai xe");
                Console.WriteLine("4.   Tim xe nhieu cho ngoi nhat");
                Console.WriteLine("5.   Sap xep danh sach xe tang dan roi xuat");
                Console.WriteLine("6.   Xuat danh sach so dep");
                Console.WriteLine("7.   Tinh so tien dang kiem dinh ky cua tung xe den thoi diem hien tai");
                Console.WriteLine("8.   Tinh thoi gian dang ky dinh ky cua tung xe sap toi");
                Console.WriteLine("9.   Tinh tong so tien da dang kiem");
                Console.WriteLine("0.   Thoát");
                Console.WriteLine("Xin hãy chọn chức năng (0-9):");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        ThemDanhSachXeOto(listc); break;
                    case "2":
                        ThemDanhSachXeTai(listv); break;
                    case "3":
                        XuatDanhSach(listc, listv); break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void ThemDanhSachXeOto(List<Cars> listc)
        {
            Console.WriteLine("Nhap thong tin xe oto");
            Cars car = new Cars();
            car.Nhap();
            listc.Add(car);
            Console.WriteLine("Them xe oto thanh cong !");
        }
        static void ThemDanhSachXeTai(List<Van> listv)
        {
            Console.WriteLine("Nhap thong tin xe tai");
            Van van = new Van();
            van.Nhap();
            listv.Add(van);
            Console.WriteLine("Them xe oto thanh cong !");
        }
        static void XuatDanhSach(List<Cars> listc, List<Van> Listv)
        {
            Console.WriteLine("Danh sach xe o to :");
            foreach (Cars car in listc)
            {
                car.Xuat();
            }
            Console.WriteLine("Danh sach xe tai :");
            foreach (Van van in Listv)
            {
                van.Xuat();
            }
        }
    }
}
        

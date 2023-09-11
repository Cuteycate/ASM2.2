using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Nhom11_ASM2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Xe> CarList = new List<Xe>();
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
                        ThemDanhSachXeOto(CarList); break;
                    case "2":
                        ThemDanhSachXeTai(CarList); break;
                    case "3":
                        XuatDanhSach(CarList); break;
                    case "4":
                        TimXeNhieuChoNgoiNhat(CarList);
                        break;
                    case "5":
                        sapxeptangdan(CarList); break;
                    case "6":
                        sodep(CarList); break;
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
        static void ThemDanhSachXeOto(List<Xe> CarList)
        {
            Console.WriteLine("Nhap thong tin xe oto");
            Xe car = new Cars();
            car.Nhap();
            CarList.Add(car);
            Console.WriteLine("Them xe oto thanh cong !");
        }
        static void ThemDanhSachXeTai(List<Xe> CarList)
        {
            Console.WriteLine("Nhap thong tin xe tai");
            Xe van = new Van();
            van.Nhap();
            CarList.Add(van);
            Console.WriteLine("Them xe oto thanh cong !");
        }
        static void XuatDanhSach(List<Xe> CarList)
        {
            Console.WriteLine("Danh sach xe o to :");
            foreach (Xe car in CarList)
            {
                if (car is Cars)
                {
                    car.Xuat();
                }
            }
            Console.WriteLine("Danh sach xe tai :");
            foreach (Xe van in CarList)
            {
                if (van is Van)
                {
                    van.Xuat();
                }
            }
        }
        static void XuatDanhSachVan(List<Xe> CarList)
        {
            Console.WriteLine("Danh sach xe tai :");
            foreach(Xe van in CarList)
            {
                if (van is Van)
                {
                    van.Xuat();
                }
            }
        }
        static void TimXeNhieuChoNgoiNhat(List<Xe> CarList)
        {
            try
            {
                var MaxChoNgoi = CarList.Where(s => s is Cars).Max(s=>(s as Cars).sochongoi).ToString();
                foreach (Cars car in CarList)
                {
                    if (car.sochongoi == Convert.ToInt32(MaxChoNgoi))
                    {
                        car.Xuat();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Khong co xe o to nao trong danh sach");
            }
        }
        static void sapxeptangdan(List<Xe> CarList)
        {
            var DanhSachVan = CarList.Where(s => s is Van).ToList();
            var sapxepvan = DanhSachVan.OrderBy(s=>(s as Van).trongtaixe).ToList();
            XuatDanhSachVan(sapxepvan);
        }
        static void sodep(List<Xe> CarList)
        {
            int count =0;
            String temp;
            var DanhSachXe = CarList.Where(s => s is Xe).ToList();
            var SoSeri = DanhSachXe.Select(s => (s as Xe).seridangky).ToList();
            for (int i = 0; i < SoSeri.Count; i++)
            {
                temp = SoSeri[i].ToString();
                while (temp.Length > 0)
                {
                    count = 0;
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (temp[0] == temp[j])
                        {
                            count++;
                        }
                    }
                    temp = temp.Replace(temp[0].ToString(), string.Empty);
                    if (count >= 4)
                    {
                        foreach (Xe xe in CarList)
                        {
                                if (xe.seridangky == SoSeri[i].ToString())
                            {
                                xe.Xuat();
                            }
                               
                        }
                    }
                }
            }
        }

    }
}
        

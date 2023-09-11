﻿using System;
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
                    case "4":
                        TimXeNhieuChoNgoiNhat(listc);
                        break;
                    case "5":
                        sapxeptangdan(listv); break;
                    case "6":
                        sodep(listv); break;
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
        static void XuatDanhSachVan(List<Van> Listv)
        {
            Console.WriteLine("Danh sach xe tai :");
            foreach(Van van in Listv)
            {
                van.Xuat();
            }
        }
        static void TimXeNhieuChoNgoiNhat(List<Cars> listc)
        {
            try
            {
                var MaxChoNgoi = listc.Max(s => s.sochongoi).ToString();
                foreach (Cars car in listc)
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
        static void sapxeptangdan(List<Van> listv)
        {
            var SapXepvan = listv.OrderBy(s=>s.trongtaixe).ToList();
            XuatDanhSachVan(SapXepvan);
        }
        static void sodep(List<Van> listv)
        {
            int count =0;
            String temp;
            var SoSeri = listv.Select(s => s.seridangky).ToList();
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
                        foreach (Van van in listv)
                        {
                            if (van.seridangky == SoSeri[i].ToString())
                            {
                                van.Xuat();
                            }
                        }
                    }
                }
            }
        }

    }
}
        

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2180607804_ngothainguyen_Lab01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentlist = new List<Student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("==========MENU===========");
                Console.WriteLine("1.   Them sinh vien");
                Console.WriteLine("2.   Hien thi danh sach sinh vien");
                Console.WriteLine("3.   Hien thi danh sach sinh vien nganh CNTT");
                Console.WriteLine("4.   Hien thi danh sach sinh vien DTB>=5");
                Console.WriteLine("5.   Hien thi danh sach sinh vien DTB tang dan");
                Console.WriteLine("6.   Hien thi danh sach sinh vien DTB >=5 va thuoc nganh CNTT");
                Console.WriteLine("7.   Hien thi danh sach sinh vien DTB cao nhat va thuoc nganh CNTT");
                Console.WriteLine("0.   Thoát");
                Console.WriteLine("Xin hãy chọn chức năng (0-2):");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        Themsinhvien(studentlist); break;
                    case "2":
                        Xuatsinhvien(studentlist); break;
                    case "3":
                        Xuattheokhoa(studentlist, "CNTT");
                        break;
                    case "4":
                        Xuatdtblonhon(studentlist, 5);
                        break;
                    case "5":
                        Xuatdtbtangdan(studentlist); break;
                    case "6":
                        XuatDSvoiDTBandNganh(studentlist, 5, "CNTT"); break;
                    case "7":
                        XuatDSDTBMaxandKhoa(studentlist, "CNTT");
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ xin hãy chọn lại.");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void Themsinhvien(List<Student> studentlist)
        {
            Console.WriteLine("nhap thong tin sinh vien");
            Student student = new Student();
            student.nhap();
            studentlist.Add(student);
            Console.WriteLine("them sinh vien thanh cong");
        }
        static void Xuatsinhvien(List<Student> studentlist)
        {
            Console.WriteLine("Danh sách chi tiết thông tin sinh viên");
            foreach (Student student in studentlist)
            {
                student.xuat();
            }
        }
        static void Xuattheokhoa(List<Student> studentlist, string khoa)
        {
            Console.WriteLine("==danh sach sinh vien thuoc khoa {0}==", khoa);
            var students = studentlist.Where(s => s.Khoa.Equals(khoa, StringComparison.OrdinalIgnoreCase)).ToList();
            Xuatsinhvien(students);
        }
        static void Xuatdtblonhon(List<Student> studentlist, float mindtb)
        {
            Console.WriteLine("===Danh sach sinh vien co diem TB >= {0}:", mindtb);
            var students = studentlist.Where(s => s.Dtb >= mindtb).ToList();
            Xuatsinhvien(students);
        }
        static void Xuatdtbtangdan(List<Student> studentlist)
        {
            Console.WriteLine("==Danh sach sinh vien duoc sap xep theo diem trung binh tang dan ===");
            var sapxepstudents = studentlist.OrderBy(s => s.Dtb).ToList();
            Xuatsinhvien(sapxepstudents);
        }
        static void XuatDSvoiDTBandNganh(List<Student> studentlist, float minDTB, String khoa)
        {
            Console.WriteLine("==Danh sach sinh vien duoc sap xep co DTB = {0} va thuoc khoa {0} ==", minDTB, khoa);
            var students = studentlist.Where(s => s.Dtb >= minDTB && s.Khoa.Equals(khoa, StringComparison.OrdinalIgnoreCase)).ToList();
            Xuatsinhvien(students);
        }
        static void XuatDSDTBMaxandKhoa(List<Student> studentlist, String khoa)
        {
            var MaxDTB = studentlist.Max(s => s.Dtb);
            foreach (var student in studentlist)
            {
                if (student.Dtb == MaxDTB && student.Khoa == khoa)
                    student.xuat();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
                Console.WriteLine("\n\n============================-------------MENU------------===============================");
                Console.WriteLine("|    1.   Them xe oto                                                                   |");
                Console.WriteLine("|    2.   Them xe tai                                                                   |");
                Console.WriteLine("|    3.   Xuat Danh sach ca hai xe                                                      |");
                Console.WriteLine("|    4.   Tim xe nhieu cho ngoi nhat                                                    |");
                Console.WriteLine("|    5.   Sap xep danh sach xe tang dan roi xuat                                        |");
                Console.WriteLine("|    6.   Xuat danh sach so dep                                                         |");
                Console.WriteLine("|    7.   Tinh so tien dang kiem dinh ky cua tung xe den thoi diem hien tai             |");
                Console.WriteLine("|    8.   Tinh thoi gian dang ky dinh ky cua tung xe sap toi                            |");
                Console.WriteLine("|    9.   Tinh tong so tien da dang kiem                                                |");
                Console.WriteLine("|    0.   Thoát                                                                         |");
                Console.WriteLine("=========================================================================================");
                Console.Write("Xin hãy chọn chức năng (0-9): ");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        ThemDanhSachXeOto(CarList); 
                        break;
                    case "2":
                        ThemDanhSachXeTai(CarList);
                        break;
                    case "3":
                        XuatDanhSach(CarList); 
                        break;
                    case "4":
                        TimXeNhieuChoNgoiNhat(CarList);
                        break;
                    case "5":
                        sapxeptangdan(CarList);
                        break;
                    case "6":
                        sodep(CarList); 
                        break;
                    case "7":
                        TienThoiGianDangKiem(CarList);
                        break;
                    case "8":
                        ThoiGianDangkiemDinhKySapToiCuaCars(CarList);
                        break;
                    case "9":
                        TongTienThoiGianDangKiem(CarList);
                        break;
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

        //------------------------------------------------------------------------------------------------------------------------
        static void ThemDanhSachXeOto(List<Xe> CarList)
        {
            Cars car;
            Console.WriteLine("\n------------Nhap thong tin xe oto-------------\n");
            car = new Cars();
            car.NhapCar();
            CarList.Add(car);
            Console.WriteLine("\n---------Them xe oto thanh cong !!!!! -----------\n");
        }

        //------------------------------------------------------------------------------------------------------------------------

        static void ThemDanhSachXeTai(List<Xe> CarList)
        {
            Van van;
            Console.WriteLine("\n------------Nhap thong tin xe tai-------------\n");
            van = new Van();
            van.NhapVan();
            CarList.Add(van);
            Console.WriteLine("\n----------Them xe tai thanh cong!!!!!-----------\n");
        }

        //------------------------------------------------------------------------------------------------------------------------
        static void XuatDanhSach(List<Xe> CarList)
        {
            Console.WriteLine("\n----------------------Danh sach xe o to ------------------------\n");
            foreach (Xe car in CarList)
            {
                if (car is Cars)
                {
                    car.Xuat();
                }
            }
            Console.WriteLine("\n-----------------------Danh sach xe tai-------------------------\n");
            foreach (Xe van in CarList)
            {
                if (van is Van)
                {
                    van.Xuat();
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        static void XuatDanhSachVan(List<Xe> CarList)
        {
            Console.WriteLine("--------------------Danh sach xe tai-------------------------");
            foreach (Xe van in CarList)
            {
                if (van is Van)
                {
                    van.Xuat();
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        static void TimXeNhieuChoNgoiNhat(List<Xe> CarList)
        {
            int count = 0;
            try
            {
                Console.WriteLine("\n --------------------- Thong Tin Xe Co Nhieu Cho Ngoi Nhat La  -------------------------\n");
                var MaxChoNgoi = CarList.Where(s => s is Cars).Max(s => (s as Cars).sochongoi).ToString();
                foreach (Cars car in CarList)
                {
                    if (car.sochongoi == Convert.ToInt32(MaxChoNgoi))
                    {
                        car.Xuat();
                        count++;
                    }
                }
            }

            catch (Exception)
            {
                if (count == 0)
                {
                    Console.WriteLine("Khong co xe o to nao trong danh sach!!!!");
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        static void sapxeptangdan(List<Xe> CarList)
        {
            var DanhSachVan = CarList.Where(s => s is Van).ToList();
            var sapxepvan = DanhSachVan.OrderBy(s => (s as Van).trongtaixe).ToList();
            Console.WriteLine("\n   !Da Sap Xep Xog! Dang Xuat Danh Sach ... \n");
            XuatDanhSachVan(sapxepvan);
        }


        //------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Kiem Tra So Dep co trong cac bien so xe
        /// </summary>
        static void sodep(List<Xe> CarList)
        {
            var bienSoXeDep1 = CarList.Where(v => v.seridangky.Count(c => c == v.seridangky[1] || c == v.seridangky[0]) >= 4 ).Select(v => v).ToList();
            Console.WriteLine("\n --------------------- Cac Bien So Dep Trong Danh Sach -----------------------\n");
            foreach (var s in bienSoXeDep1)
            {
                Console.Write("" + s.matinh + " - " + s.seridangky + ", ");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Ham Tinh Tien Dang Kiem Dinh Ky cua cac loai xe tu truoc toi nay
        /// </summary> 
        static void TienThoiGianDangKiem(List<Xe> CarList)
        {
            double tien = 0;
            var danhsachxe = CarList.Where(s => s is Cars).ToList();
            var danhsachvan = CarList.Where(s => s is Van).ToList();
            // Tien cua Cars     
            //------------------------------------------------------------------------------------------------------------------------
            Console.Write("\n       ________________________So Tien Dang Kiem Cua Xe ___________________________\n");
            foreach (Cars car in danhsachxe)
            {

                var totalmonths = (DateTime.Now.Month - car.ngaysanxuat.Month + 12 * (DateTime.Now.Year - car.ngaysanxuat.Year));
                int temp = (totalmonths - 84);
                if (car.sochongoi <= 10)
                {
                    if (totalmonths <= 84)
                    {
                        tien = ((totalmonths) / ThoiGianDangKiemXeReturn(car,totalmonths) * 240000);
                    }
                    if (totalmonths > 84)
                    {
                        tien = (84 / ThoiGianDangKiemXeReturn(car, temp)) * 240000 + (((temp) / ThoiGianDangKiemXeReturn(car, totalmonths) * 240000));
                    }
                    car.Xuat();
                    Console.Write(" - Tien dang kiem cua xe la : {0} VND", tien);
                    Console.Write("\n--------------------------------------------------------------------------------------------------------------------\n");
                    tien = 0;
                }
                if (car.sochongoi > 10)
                {
                    if (totalmonths < 84)
                    {
                        tien = (totalmonths / ThoiGianDangKiemXeReturn(car, totalmonths)) * 320000;
                    }
                    if (totalmonths > 84)
                    {
                        tien = (84 / ThoiGianDangKiemXeReturn(car,temp)) * 320000;
                        tien = (tien + ((temp) / ThoiGianDangKiemXeReturn(car,totalmonths) * 320000));
                    }
                    car.Xuat();
                    Console.Write(" - Tien dang kiem cua xe la : {0} VND", tien);
                    Console.Write("\n--------------------------------------------------------------------------------------------------------------------\n");
                    tien = 0;
                }
            }
            //Tien cua Vans
            //---------------------------------------------------------------------------------------------------------------------------------
            //Console.Write("\n_____________So tien Dang Kiem Cua Xe Tai______________\n");
            foreach (Van van in danhsachvan)
            {
                var totalmonths = (DateTime.Now.Month - van.ngaysanxuat.Month + 12 * (DateTime.Now.Year - van.ngaysanxuat.Year));
                int temp = (totalmonths - 240);
                if (van.trongtaixe > 20)
                {
                    if (totalmonths <= 240)
                    {
                        tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van,totalmonths) * 560000);
                    }
                    if (totalmonths > 240)
                    {
                        tien = (240) / ThoiGianKiemDinhVanReTurn(van,temp) * 560000 + (((temp) / ThoiGianKiemDinhVanReTurn(van,totalmonths) * 560000));
                    }
                    van.Xuat();
                    Console.Write(" - Tien dang kiem cua xe la : {0} VND", tien);
                    Console.Write("\n----------------------------------------------------------------------------------------------------------------------\n");
                    tien = 0;
                }
                if (van.trongtaixe <= 20 && van.trongtaixe > 7)
                {
                    if (totalmonths <= 240)
                    {
                        tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van, totalmonths) * 350000);
                    }
                    if (totalmonths > 240)
                    {
                        tien = ((240) / ThoiGianKiemDinhVanReTurn(van,temp) * 350000 + ((temp) / ThoiGianKiemDinhVanReTurn(van,totalmonths) * 350000));
                    }
                    van.Xuat();
                    Console.Write(" - Tien dang kiem cua xe la : {0} VND", tien);
                    Console.Write("\n-----------------------------------------------------------------------------------------------------------------------\n");
                    tien = 0;
                }
                if (van.trongtaixe <= 7)
                {
                    if (totalmonths <= 240)
                    {
                        tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van, totalmonths) * 320000);
                    }
                    if (totalmonths > 240)
                    {
                        tien = ((240) / ThoiGianKiemDinhVanReTurn(van,temp) * 320000 + (temp) / ThoiGianKiemDinhVanReTurn(van,temp) * 320000);
                    }
                    van.Xuat();
                    Console.Write(" - Tien dang kiem cua xe la : {0} VND", tien);
                    Console.Write("\n-------------------------------------------------------------------------------------------------------------------------\n");
                    tien = 0;
                }
            }
        }

        /// <summary>
        //  Ham Tinh Thoi Gian Dang Kiem Cua Cac Xe
        /// </summary> 
        static void ThoiGianDangkiemDinhKySapToiCuaCars(List<Xe> CarList)
        {
            var danhsachxe = CarList.Where(s => s is Cars).ToList();
            var danhsachvan = CarList.Where(s => s is Van).ToList();
            // Thoi Gian Dang Kiem Sap Toi Cua Cars
            //------------------------------------------------------------------------------------------------------------------------
            Console.Write("\n_________________________Thoi Gian Dang Kiem Sap Toi Cua Xe _________________________\n");
            foreach (Cars car in danhsachxe)
            {
                DateTime amongus, amongus0;
                int temp = 0, temp1 = 0;

                Console.WriteLine();

                int ThoiGianDangKiem = 0;

                var totalmonths = (DateTime.Now.Month - car.ngaysanxuat.Month + 12 * (DateTime.Now.Year - car.ngaysanxuat.Year));

                if (totalmonths <= 84)
                {
                    ThoiGianDangKiem = totalmonths + ThoiGianDangKiemXeReturn(car,totalmonths) - (totalmonths%ThoiGianDangKiemXeReturn(car,totalmonths));
                    
                }
                if (totalmonths > 84)
                {
                    //tinh so du giua tong thang va thoi gian dang kiem 
                    temp1 = totalmonths % ThoiGianDangKiemXeReturn(car,totalmonths);
            
                    ThoiGianDangKiem = totalmonths + ThoiGianDangKiemXeReturn(car,totalmonths) - temp1;

                }



                car.Xuat();
                // Console.Write("Thoi Gian Dang Kiem cua Xe Sap Toi:{0}\n", ThoiGianDangKiemXe);


                //tu dong cap nhat lai nam khi thang lon hon 12
                amongus = new DateTime(car.ngaysanxuat.Year, car.ngaysanxuat.Month, car.ngaysanxuat.Day).AddMonths(ThoiGianDangKiem);

                Console.WriteLine(" - Thoi Gian Dang Kiem Sap Toi Cua Xe: {0} ", amongus);

                Console.Write("\n--------------------------------------------------------------------------------------------------------------\n");

            }
            // Thoi Gian Dag Kiem sap Toi cua Vans
            //------------------------------------------------------------------------------------------------------------------------------------
            foreach (Van van in danhsachvan)
            {
                DateTime amongus;
                int ThoiGianDangKiem = 0;
                var totalmonths = (DateTime.Now.Month - van.ngaysanxuat.Month + 12 * (DateTime.Now.Year - van.ngaysanxuat.Year));
              
                int temp1 = totalmonths % ThoiGianKiemDinhVanReTurn(van,totalmonths);
            
                ThoiGianDangKiem = totalmonths + ThoiGianKiemDinhVanReTurn(van,totalmonths) - temp1;
            

                van.Xuat();
                // Console.Write("Thoi Gian Dang Kiem cua Xe Sap Toi:{0}\n", ThoiGianDangKiem);
                amongus = new DateTime(van.ngaysanxuat.Year, van.ngaysanxuat.Month, van.ngaysanxuat.Day).AddMonths(ThoiGianDangKiem);
                Console.WriteLine(" - Thoi Gian Dang Kiem Sap Toi Cua Xe: {0} ", amongus);

                Console.Write("\n--------------------------------------------------------------------------------------------------------------\n");


            }
        }
        /// <summary>
        /// Chu Ky Dang Kiem Cua Cars
        /// </summary>   
        //------------------------------------------------------------------------------------------------------------------------
        static int ThoiGianDangKiemXeReturn(Cars car,int totalmonths)
        {
            int ThoiGianDinhKy = 0;
            {
                totalmonths = (Math.Abs(DateTime.Now.Month - car.ngaysanxuat.Month) + 12 * (DateTime.Now.Year - car.ngaysanxuat.Year));
                {
                    if (totalmonths <= 84 && car.sochongoi <= 9 && car.kinhdoanhvantai == false)
                    {

                        ThoiGianDinhKy = 24;
                    }

                    else if (totalmonths <= 84 && car.sochongoi <= 9 && car.kinhdoanhvantai == true)
                    {
                        ThoiGianDinhKy = 12;
                    }

                    else if (totalmonths <= 84 && car.sochongoi > 9)
                    {
                        ThoiGianDinhKy = 12;
                    }
                    else                 
                    {
                        ThoiGianDinhKy = 6;

                    }
             
                }

                return ThoiGianDinhKy;
            }
       
        }

        /// <summary>
        ///Chu Ki Dang Kiem cua van
        /// </summary>
        //------------------------------------------------------------------------------------------------------------------------
        static int ThoiGianKiemDinhVanReTurn(Van van,int totalmonths)
        {
            int ThoiGianDinhKy = 0;
            totalmonths = (DateTime.Now.Month - van.ngaysanxuat.Month + 12 * (DateTime.Now.Year - van.ngaysanxuat.Year));
            {

                if (totalmonths <= 240)
                {
                    ThoiGianDinhKy = 6;
                }
                if(totalmonths>240)
                {
                    ThoiGianDinhKy = 3;
                }
            }
            return ThoiGianDinhKy;
        }
        static void TongTienThoiGianDangKiem(List<Xe> CarList)
        {
            {
                double tien = 0;
                double tongtien = 0;
                var danhsachxe = CarList.Where(s => s is Cars).ToList();
                var danhsachvan = CarList.Where(s => s is Van).ToList();
                // Tien cua Cars     
                //------------------------------------------------------------------------------------------------------------------------
                foreach (Cars car in danhsachxe)
                {  var totalmonths = (DateTime.Now.Month - car.ngaysanxuat.Month + 12 * (DateTime.Now.Year - car.ngaysanxuat.Year));
                    int temp =(totalmonths - 84);
                    if (car.sochongoi <= 10)
                    {
                        if (totalmonths <= 84)
                        {
                            tien = ((totalmonths) / ThoiGianDangKiemXeReturn(car, totalmonths) * 240000);
                        }
                        if (totalmonths > 84)
                        {
                            tien = (84 / ThoiGianDangKiemXeReturn(car, temp)) * 240000 + (((temp) / ThoiGianDangKiemXeReturn(car, totalmonths) * 240000));
                            tongtien = tongtien + tien;
                        }
                        tien = 0;
                    }
                    if (car.sochongoi > 10)
                    {
                        if (totalmonths < 84)
                        {
                            tien = (totalmonths / ThoiGianDangKiemXeReturn(car, totalmonths)) * 320000;
                            tongtien = tongtien + tien;
                        }
                        if (totalmonths > 84)
                        {
                            tien = (84 / ThoiGianDangKiemXeReturn(car, temp)) * 320000;
                            tien = (tien + ((temp) / ThoiGianDangKiemXeReturn(car, totalmonths) * 320000));
                            tongtien = tongtien + tien;
                        }
                        
                    }
                }
                //Tien cua Vans
                //---------------------------------------------------------------------------------------------------------------------------------
                foreach (Van van in danhsachvan)
                {
                    var totalmonths = (DateTime.Now.Month - van.ngaysanxuat.Month + 12 * (DateTime.Now.Year - van.ngaysanxuat.Year));
                    int temp = (totalmonths - 240);
                    if (van.trongtaixe > 20)
                    {
                        if (totalmonths <= 240)
                        {
                            tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van, totalmonths) * 560000);
                            tongtien = tongtien + tien;
                        }
                        if (totalmonths > 240)
                        {
                            tien = (240) / ThoiGianKiemDinhVanReTurn(van, temp) * 560000 + (((temp) / ThoiGianKiemDinhVanReTurn(van, totalmonths) * 560000));
                            tongtien = tongtien + tien;                        }
                        tongtien = tongtien + tien;
                    }
                    if (van.trongtaixe <= 20 && van.trongtaixe > 7)
                    {
                        if (totalmonths <= 240)
                            tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van, totalmonths) * 350000);
                              tongtien = tongtien + tien;
                        if (totalmonths > 240)
                        {
                            tien = ((240) / ThoiGianKiemDinhVanReTurn(van, temp) * 350000 + ((temp) / ThoiGianKiemDinhVanReTurn(van, totalmonths) * 350000));
                            tongtien = tongtien + tien;
                        }
                        tien = 0;
                    }
                    if (van.trongtaixe <= 7)
                    {
                        if (totalmonths <= 240)
                            tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van, totalmonths) * 320000);
                            tongtien = tongtien + tien;
                        if (totalmonths > 240)
                        {
                            tien = ((240) / ThoiGianKiemDinhVanReTurn(van, temp) * 320000 + (temp) / ThoiGianKiemDinhVanReTurn(van, temp) * 320000);
                            tongtien = tongtien + tien;
                        }
                    }
                }
                Console.WriteLine("\n - Tong tien thu duoc la : {0} VND", tongtien);
            }
        }
    }
}

    
        

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
            Console.WriteLine("Nhap thong tin xe oto");
            car = new Cars();
            car.NhapCar();
            CarList.Add(car);
            Console.WriteLine("Them xe oto thanh cong !");
        }

        //------------------------------------------------------------------------------------------------------------------------

        static void ThemDanhSachXeTai(List<Xe> CarList)
        {
            Van van;
            Console.WriteLine("Nhap thong tin xe tai");
            van = new Van();
            van.NhapVan();
            CarList.Add(van);
            Console.WriteLine("Them xe tai thanh cong !");
        }

        //------------------------------------------------------------------------------------------------------------------------
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

        //------------------------------------------------------------------------------------------------------------------------

        static void XuatDanhSachVan(List<Xe> CarList)
        {
            Console.WriteLine("Danh sach xe tai :");
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
                    Console.WriteLine("Khong co xe o to nao trong danh sach");
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        static void sapxeptangdan(List<Xe> CarList)
        {
            var DanhSachVan = CarList.Where(s => s is Van).ToList();
            var sapxepvan = DanhSachVan.OrderBy(s => (s as Van).trongtaixe).ToList();
            XuatDanhSachVan(sapxepvan);
        }


        //------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Kiem Tra So Dep co trong cac bien so xe
        /// </summary>
        static void sodep(List<Xe> CarList)
        {
           
            var bienSoXeDep1 = CarList.Where(v => v.seridangky.Count(c => c == v.seridangky[1]) >= 4).Select(v => v).ToList();
            foreach (var s in bienSoXeDep1)
            {
                Console.WriteLine(" " + s.matinh + " - " + s.seridangky + ",");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Ham Tinh Tien Dang Kiem Dinh Ky cua cac loai xe tu truoc toi nay
        /// </summary> 
        static void TienThoiGianDangKiem(List<Xe> CarList)
        {
            float tien = 0;
            var danhsachxe = CarList.Where(s => s is Cars).ToList();
            var danhsachvan = CarList.Where(s => s is Van).ToList();
      // Tien cua Cars     
     //------------------------------------------------------------------------------------------------------------------------
            foreach (Cars car in danhsachxe)
            {
                var totalmonths = (DateTime.Now.Month - car.ngaysanxuat.Month + 12 * (DateTime.Now.Year - car.ngaysanxuat.Year));
       
                if (car.sochongoi <= 10)
                {
                    if (totalmonths <= 84)
                    {
                        tien = ((totalmonths) / ThoiGianDangKiemXeReturn(car) * 240000);
                    }
                    if (totalmonths > 84)
                    {
                        tien = (84 / ThoiGianDangKiemXeReturn(car)) * 240000 + (((totalmonths - 84) / 6) * 240000);
                    }
                    car.Xuat();
                    Console.Write("So tien:{0}", tien);
                    tien = 0;
                }
                if (car.sochongoi > 10)
                {
                    if (totalmonths < 84)
                    {
                        tien = (totalmonths / ThoiGianDangKiemXeReturn(car)) * 320000;
                    }
                    if (totalmonths > 84)
                    {
                        tien = (84 / ThoiGianDangKiemXeReturn(car)) * 320000;
                        tien = (tien + ((totalmonths - 84) / 6) * 320000);
                    }
                    car.Xuat();
                    Console.Write("So tien:{0}", tien);
                    tien = 0;
                }
            }
      //Tien cua Vans
     //---------------------------------------------------------------------------------------------------------------------------------
            foreach (Van van in danhsachvan)
            {
                var totalmonths = (DateTime.Now.Month - van.ngaysanxuat.Month + 12 * (DateTime.Now.Year - van.ngaysanxuat.Year));
                if (van.trongtaixe > 20)
                {
                    if (totalmonths < 240)
                    {
                        tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van) * 560000);
                    }
                    if (totalmonths > 240)
                    {
                        tien = ((totalmonths - 240) / ThoiGianKiemDinhVanReTurn(van) * 560000 + (((totalmonths - 240) / 3) * 560000));
                    }
                    van.Xuat(); Console.Write("So tien:{0}", tien);
                    tien = 0;
                }
                if (van.trongtaixe < 20 && van.trongtaixe > 7)
                {
                    if (totalmonths < 240)
                        tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van) * 350000);
                    if (totalmonths > 240)
                    {
                        tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van) * 350000 + ((totalmonths - 240) / 3) * 350000);
                    }
                    van.Xuat();
                    Console.Write("So tien:{0}", tien);
                    tien = 0;
                }
                if (van.trongtaixe < 7)
                {
                    if (totalmonths < 240)
                        tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van) * 320000);
                    if (totalmonths > 240)
                    {
                        tien = ((totalmonths) / ThoiGianKiemDinhVanReTurn(van) * 320000 + ((totalmonths - 240) / 3) * 320000);
                    }
                    van.Xuat();
                    Console.Write("So tien:{0}", tien);
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
            foreach (Cars car in danhsachxe)
            {
                 DateTime amongus, amongus0;
                int temp = 0, temp1 = 0 ;

                Console.WriteLine();
                            
                int ThoiGianDangKiem = 0;
                var totalmonths = ( DateTime.Now.Month - car.ngaysanxuat.Month + 12 * (DateTime.Now.Year - car.ngaysanxuat.Year));
                Console.WriteLine(totalmonths);
                    if (totalmonths <= 84)
                    {
                        ThoiGianDangKiem = totalmonths + ThoiGianDangKiemXeReturn(car);
                        Console.WriteLine(ThoiGianDangKiem);
                      }
                    if (totalmonths > 84)
                    {
                            temp1 = totalmonths % ThoiGianDangKiemXeReturn(car);

                            Console.WriteLine(temp1);
                            
                            ThoiGianDangKiem = totalmonths  + ThoiGianDangKiemXeReturn(car) - temp1;
                           

                                         


                            Console.WriteLine(ThoiGianDangKiem) ;
                            Console.WriteLine(temp1);
                        
                    }

              

                car.Xuat();
                // Console.Write("Thoi Gian Dang Kiem cua Xe Sap Toi:{0}\n", ThoiGianDangKiemXe);
                 


                 amongus = new DateTime(car.ngaysanxuat.Year, car.ngaysanxuat.Month, car.ngaysanxuat.Day ).AddMonths(ThoiGianDangKiem); 
                    
                    Console.WriteLine(amongus);
                       
                
                
                /*DateTime amongus;

                int b = car.ngaysanxuat.Month;
                int a = car.ngaysanxuat.Day;
                int c = car.ngaysanxuat.Year;

                



                while( c <= DateTime.Now.Year)
                {
                    if ( a >= DateTime.Now.Day && b >= DateTime.Now.Month  && c == DateTime.Now.Year )
                    {
                        break;
                    }
                    if ( b > DateTime.Now.Month && c > DateTime.Now.Year )
                    {
                        break;
                    }
                    b += ThoiGianDangKiemXeReturn(car);
                    if ( b > 12 )
                    {
                        b -= 12;
                        c++;
                    }

                              
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);


                
                //Console.WriteLine(amongus);


                */

            }
      // Thoi Gian Dag Kiem sap Toi cua Vans
     //------------------------------------------------------------------------------------------------------------------------------------
            foreach( Van van in danhsachvan)
            {
                DateTime amongus;
                int ThoiGianDangKiem = 0;
                var totalmonths = (DateTime.Now.Month - van.ngaysanxuat.Month + 12 * (DateTime.Now.Year - van.ngaysanxuat.Year));
                Console.WriteLine(totalmonths);
                int temp1 = totalmonths % ThoiGianKiemDinhVanReTurn(van);
                Console.WriteLine(temp1);
                ThoiGianDangKiem = totalmonths + ThoiGianKiemDinhVanReTurn(van) - temp1;
                Console.WriteLine(ThoiGianDangKiem);

                van.Xuat();
               // Console.Write("Thoi Gian Dang Kiem cua Xe Sap Toi:{0}\n", ThoiGianDangKiem);
                amongus = new DateTime(van.ngaysanxuat.Year, van.ngaysanxuat.Month, van.ngaysanxuat.Day).AddMonths(ThoiGianDangKiem);
                Console.WriteLine(amongus);


            }
        }

        /// <summary>
        /// Chu Ky Dang Kiem Cua Cars
        /// </summary>   
        //------------------------------------------------------------------------------------------------------------------------
        static int ThoiGianDangKiemXeReturn(Cars car)
        {
            int ThoiGianDinhKy = 1;
            {
                var totalmonths = (Math.Abs(DateTime.Now.Month - car.ngaysanxuat.Month) + 12 * (DateTime.Now.Year - car.ngaysanxuat.Year));
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
                        ThoiGianDinhKy = 12;

                    }
                    if ( totalmonths > 84)
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
        static int ThoiGianKiemDinhVanReTurn(Van van)
        {
            int ThoiGianDinhKy = 0;
            var totalmonths = (DateTime.Now.Month - van.ngaysanxuat.Month + 12 * (DateTime.Now.Year - van.ngaysanxuat.Year));
            {

                if (totalmonths <= 240)
                {
                    ThoiGianDinhKy = 6;
                }
                else
                {
                    ThoiGianDinhKy = 3;
                }
            }

            return ThoiGianDinhKy;
        }
    }
}

    
        

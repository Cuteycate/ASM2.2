using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_ASM2._2
{
    class Cars : Xe
    {
        public int sochongoi;
        public bool kinhdoanhvantai;


        int Sochongoi { get => sochongoi; set => sochongoi = value; }
        bool Kinhdoanhvantai { get => kinhdoanhvantai; set => kinhdoanhvantai = value; }
        public Cars(DateTime ngaysanxuat,string matinh,string seridangky,int sochongoi, bool kinhdoanhvantai) : base(ngaysanxuat,matinh,seridangky)
        {
            this.sochongoi = sochongoi;
            this.kinhdoanhvantai = kinhdoanhvantai;
        }
        public Cars()
        {

        }
        public void Nhap()
        {

            Console.WriteLine("Nhap ngay thang nam san xuat : (vd : 23/03/2003)");
            ngaysanxuat = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ma tinh");
            matinh = Console.ReadLine();
            Console.Write("Nhap so seri dang ky:");
            seridangky = Console.ReadLine();
            Console.Write("Nhap so cho ngoi cua xe:");
            sochongoi = Convert.ToInt32(Console.ReadLine());
            int choice;
            do
            {
                Console.Write("Co dang ky kinh doanh van tai hay khong ? (chon 0 hoac 1)");
                choice = Convert.ToInt32(Console.ReadLine());
                {
                    if (choice == 0)
                    {
                        kinhdoanhvantai = false;
                    }
                    else
                    {
                        kinhdoanhvantai = true;
                    }
                }
            } while (choice > 1);
        }
        public void Xuat()
        {
            Console.WriteLine("Ngay san xuat :" + ngaysanxuat + "\tbien so xe: {0}-{1}\t so cho ngoi {2}\t co dang ky kinh doanh van tai hay khong : {3}",matinh,seridangky,sochongoi,kinhdoanhvantai);
        }
    }
}

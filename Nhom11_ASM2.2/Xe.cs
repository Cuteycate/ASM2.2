using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_ASM2._2
{
   class Xe
    {
        public DateTime ngaysanxuat;
        public string matinh;
        public string seridangky;


        DateTime Ngaysanxuat { get => ngaysanxuat; set => ngaysanxuat = value; }
        string Matinh { get => matinh; set => matinh = value; }
        string Seridangky { get => seridangky; set => seridangky = value; }
        public Xe(DateTime ngaysanxuat, string matinh, string seridangky)
        {
            this.ngaysanxuat = ngaysanxuat;
            this.matinh = matinh;
            this.seridangky = seridangky;
        }
        public Xe()
        {

        }
        public void Nhap()
        {
            bool Choice;
            do
            {
                try
                {
                    Choice = true;
                    Console.Write(" - Nhap ngay thang nam san xuat ( 23/03/2003 ): ");
                    ngaysanxuat = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n Thoi gian khong hop le! Vui long nhap lai: \n");
                    Choice = false;
                }
            } while (Choice == false);
            do
            {
                Console.Write(" - Nhap ma tinh (4 chu): ");
                matinh = Console.ReadLine();
                if (matinh.Length != 4)
                {
                    Console.WriteLine("\n - Ma tinh phai co 4 chu so!!!!!\n");
                }
            } while (matinh.Length != 4);
            do
            {
                Console.Write(" - Nhap so seri dang ky: ");
                seridangky = Console.ReadLine();
                if (seridangky.Length != 5)
                {
                    Console.WriteLine("\nso seri dang ky phai 5 chu so!!!!!!\n");
                }
            } while (seridangky.Length != 5);
        }
        public virtual void Xuat()
        {
            Console.Write("\n - Ngay san xuat :" + ngaysanxuat + "  |\tBien so xe: {0}-{1}  |", matinh, seridangky);
         }
    }
}

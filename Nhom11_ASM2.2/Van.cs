using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq.Expressions;

namespace Nhom11_ASM2._2
{
    internal class Van : Xe
    {
        public int trongtaixe { get; set; }

        public Van(DateTime ngaysanxuat, string matinh, string seridangky, int trongtaixe) : base(ngaysanxuat, matinh, seridangky)
        {
            this.trongtaixe = trongtaixe;
        }
        public Van() { }
        public void Nhap()
        {
            bool Choice;
            do
            {
                try
                {
                    Choice = true;
                    Console.WriteLine("Nhap ngay thang nam san xuat : (vd : 23/03/2003)");
                    ngaysanxuat = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Thoi gian khong hop le !");
                    Choice = false;
                }
            } while (Choice == false);
            do
            {
                Console.Write("Nhap ma tinh (4 chu)");
                matinh = Console.ReadLine();
                if (matinh.Length > 4)
                {
                    Console.WriteLine("Ma tinh phai co it nhat 4 chu so");
                }
            } while (matinh.Length > 4);
            do
            {
                Console.Write("Nhap so seri dang ky:");
                seridangky = Console.ReadLine();
                if (seridangky.Length > 5)
                {
                    Console.WriteLine("so seri dang ky phai co it nhat 4 chu so");
                }
            } while (seridangky.Length > 5);
            Console.Write("Nhap trong tai cua xe tai:");
            trongtaixe = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ngay san xuat :" + ngaysanxuat + "\t bien so xe: {0}-{1}\t trong tai xe {2}", matinh, seridangky, trongtaixe);
        }

    }
}

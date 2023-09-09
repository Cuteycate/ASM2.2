using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
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
            Console.WriteLine("Nhap ngay thang nam san xuat : (vd : 23/03/2003)");
            ngaysanxuat = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ma tinh");
            matinh = Console.ReadLine();
            Console.Write("Nhap so seri dang ky:");
            seridangky = Console.ReadLine();
            Console.Write("Nhap trong tai cua xe tai:");
            trongtaixe = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ngay san xuat :" + ngaysanxuat + "\t bien so xe: {0}-{1}\t trong tai xe {2}", matinh, seridangky, trongtaixe);
        }

    }
}

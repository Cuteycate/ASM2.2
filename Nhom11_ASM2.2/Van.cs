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
        public void NhapVan()
        {
            base.Nhap();
            Console.Write(" - Nhap trong tai cua xe tai: ");
            trongtaixe = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat(); Console.Write("\t trong tai xe {0}  (tan)\n", trongtaixe);
        }

    }
}

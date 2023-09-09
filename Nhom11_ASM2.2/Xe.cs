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

    }
}

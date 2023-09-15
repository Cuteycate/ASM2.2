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
        public void NhapCar()
        {
            base.Nhap();
            Console.Write(" - Nhap so cho ngoi cua xe: ");
            sochongoi = Convert.ToInt32(Console.ReadLine());
            int choice;
            do
            {
                Console.WriteLine(" - Co dang ky kinh doanh van tai hay khong ?" );
                Console.Write("      Chon 1 La Co - Chon 0 la Khong, Chon: ");
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
        public override void Xuat()
        {
            base.Xuat(); Console.Write("\t So cho ngoi: {0}   cho  Kdvt : {1}  |\n", sochongoi, kinhdoanhvantai);
        }
    }
}

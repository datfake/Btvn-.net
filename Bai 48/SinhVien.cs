using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_11
{
    class SinhVien
    {
        private String mssv;
        private String tenSV;
        private String khoa;
        private float diemTB;
        private float diemRL;
        private String xl;

        public SinhVien(String mssv, String tenSV, String khoa, float diemTB, float diemRL)
        {
            this.mssv = mssv;
            this.tenSV = tenSV;
            this.khoa = khoa;
            this.diemTB = diemTB;
            this.diemRL = diemRL;
            if (diemTB >= 9.0 && diemRL >= 90) this.xl = "xuat sac";
            else if (diemTB >= 9.0 && diemRL >= 80) this.xl = "gioi";
            else if (diemTB >= 9.0 && diemRL >= 70) this.xl = "kha";
            else if (diemTB >= 8.0 && diemRL >= 80) this.xl = "gioi";
            else if (diemTB >= 8.0 && diemRL >= 70) this.xl = "kha";
            else if (diemTB >= 7.0 && diemRL >= 80) this.xl = "gioi";
            else this.xl = "yeu";
        }

        public String getMSSV()
        {
            return this.mssv;
        }

        public void Xuat()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}",this.mssv,this.tenSV,this.khoa,this.diemTB,this.diemRL,this.xl);
        }

    }

}

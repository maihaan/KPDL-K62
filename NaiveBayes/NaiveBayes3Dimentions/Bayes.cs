using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace NaiveBayes3Dimentions
{
    public class Bayes
    {
        /* Bài toán
         * - INPUT: Tập các điểm và số nhóm cần phân chia
         * - OUTPUT: Các điểm đã được phân chia hợp lý vào
         * các nhóm
         * - CÁC BƯỚC THỰC HIỆN:
         * B1: Lấy n điểm bất kỳ tương ứng với n nhóm cần phân
         * chia làm tâm các nhóm (*)
         * B2: Tính khoảng cách từ các điểm đến từng tâm nhóm
         * nếu điểm đó gần tâm nhóm nào nhất thì nạp điểm đó
         * vào nhóm đó.(*)
         * B3: Tính lại tâm của các nhóm
         * B4: Kiểm tra xem tâm các nhóm có thay đổi hay không
         * Nếu tâm nhóm thay đổi thì quay lại Bước 2. Nếu tâm
         * nhóm không thay đổi thì kết thúc.
         * 
         */ 
         
        public List<Diem> DocDuLieu(String duongDan)
        {
            String dl = File.ReadAllText(duongDan);
            List<Diem> ds = new List<Diem>();
            if (dl.Length > 0 && dl.Contains("\r\n") && dl.Contains(","))
            {
                foreach (String dong in dl.Split('\r'))
                {
                    if (String.IsNullOrEmpty(dong.Trim()))
                        continue;
                    String tmp = dong.Replace("\n", "").Trim();
                    float x = float.Parse(tmp.Split(',')[0].Trim());
                    float y = float.Parse(tmp.Split(',')[1].Trim());
                    float z = float.Parse(tmp.Split(',')[2].Trim());
                    Diem d = new Diem();
                    d.X = x;
                    d.Y = y;
                    d.Z = z;
                    ds.Add(d);
                }
                return ds;
            }
            else
                return null;
        }

        public List<Nhom> KhoiTaoNhom(int soNhom, List<Diem> dsDiem)
        {
            int soDiem = dsDiem.Count;
            Random r = new Random();

            List<Nhom> dsNhom = new List<Nhom>();
            for(int i = 0; i < soNhom; i++)
            {
                Nhom n = new Nhom();
                n.Ma = i;
                n.Ten = "Nhóm thứ " + i.ToString();
                Diem d = dsDiem[r.Next(soDiem - 1)];
                n.X = d.X;
                n.Y = d.Y;
                n.Z = d.Z;
                dsNhom.Add(n);
            }
            return dsNhom;

        }

        public List<Diem> ChiaNhom(List<Nhom> dsNhom, List<Diem> dsDiem)
        {
            // Duyet tung diem va tinh khoang cach tu diem do den tam cac nhom
            foreach(Diem d in dsDiem)
            {
                float khoangCachNhoNhat = 0;
                int MaNhom = -1;
                foreach(Nhom n in dsNhom)
                {
                    float khoangCach = (float)Math.Sqrt((d.X - n.X) * (d.X - n.X)
                        + (d.Y - n.Y) * (d.Y - n.Y)
                        + (d.Z - n.Z) * (d.Z - n.Z));
                    if(khoangCachNhoNhat == 0 || khoangCach < khoangCachNhoNhat)
                    {
                        khoangCachNhoNhat = khoangCach;
                        MaNhom = n.Ma;
                    }
                }
                d.MaNhom = MaNhom;
            }

            // Tinh lai tam cua tung nhom            
            while (true)
            {
                Boolean thayDoi = false;
                foreach (Nhom n in dsNhom)
                {
                    float xMoi = 0;
                    float yMoi = 0;
                    float zMoi = 0;
                    int dem = 0;
                    foreach(Diem d in dsDiem)
                    {
                        if(d.MaNhom == n.Ma)
                        {
                            xMoi += d.X;
                            yMoi += d.Y;
                            zMoi += d.Z;
                            dem++;
                        }
                    }
                    if (dem > 0)
                    {
                        xMoi = xMoi / dem;
                        yMoi = yMoi / dem;
                        zMoi = zMoi / dem;

                        // Kiem tra xem co thay doi khong, neu thay doi thi cap nhat
                        if (n.X != xMoi || n.Y != yMoi || n.Z != zMoi)
                        {
                            thayDoi = true;
                            n.X = xMoi;
                            n.Y = yMoi;
                            n.Z = zMoi;
                        }
                    }   
                }
                // Kiem tra xem danh sach nhom co bien dong khong
                if (thayDoi == false)
                    break;
            }
            return dsDiem;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NaiveBayes3Dimentions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Data text file (*.txt) | *.txt";
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // Kiem tra dau vao gom: tep tin du lieu va so nhom
            if(tbDuongDan.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tệp tin chứa các điểm");
                btTim.Focus();
                return;
            }
            if(nudSoNhom.Value < 2)
            {
                MessageBox.Show("Số nhóm phải lớn hơn hoặc bằng 2");
                nudSoNhom.Focus();
                return;
            }

            // Xử lý dữ liệu
            tbKetQua.Text = "";
            Bayes bs = new Bayes();
            List<Diem> dsDiem = bs.DocDuLieu(tbDuongDan.Text);
            if(dsDiem != null && dsDiem.Count > 0)
            {
                List<Nhom> dsNhom = bs.KhoiTaoNhom((int)nudSoNhom.Value, dsDiem);
                dsDiem = bs.ChiaNhom(dsNhom, dsDiem);

                // Hien thi ket qua len textbox                
                foreach(Nhom n in dsNhom)
                {
                    tbKetQua.Text += n.Ten + "\r\n";
                    foreach(Diem d in dsDiem)
                    {
                        if(d.MaNhom == n.Ma)
                        {
                            tbKetQua.Text += "[" + d.X.ToString("0.00")
                                + " , " + d.Y.ToString("0.00") + " , " + d.Z.ToString() + "]; ";
                        }
                    }
                    tbKetQua.Text += "\r\n\r\n";
                }
            }
        }
    }
}

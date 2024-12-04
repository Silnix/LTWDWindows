using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiWDFA0301
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
    }

    public class KhachHang
    {
        public string hoten, dienthoai, diachi;
        public int namsinh;
        public bool gioitinh;

        public KhachHang(string hoten, string dienthoai, string diachi, int namsinh, bool gioitinh)
        {
            this.hoten = hoten;
            this.dienthoai = dienthoai;
            this.diachi = diachi;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
        }
        public string HoTen
        {
            get { return tbHoten.Text; }
            set { tbHoten.Text = value; }
        }

        public string DienThoai
        {
            get { return tbDienthoai.Text; }
            set { tbDienthoai.Text = value; }
        }

        public string DiaChi
        {
            get { return tbDiachi.Text; }
            set { tbDiachi.Text = value; }
        }

        public int NamSinh
        {
            get { return int.Parse(tbNamsinh.Text); }
            set { tbNamsinh.Text = value.ToString(); }
        }

        public bool GioiTinh
        {
            get { return rbNam.Checked; }
            set { rbNam.Checked = value; rbNu.Checked = !value; }
        }
    }
}

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
    public partial class MainForm : Form
    {
        private ArrayList dsKhachHang = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
            btSua.Enabled = false;
            btXemThongTin.Enabled = false;
            btXoa.Enabled = false;
            btXoaHet.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                KhachHang kh = new KhachHang(
                    frm.HoTen,
                    frm.DienThoai,
                    frm.DiaChi,
                    frm.NamSinh,
                    frm.GioiTinh
                );
                dsKhachHang.Add(kh);
                CapNhatDanhSach();
                EnableButtons();
            }
        }

        private void CapNhatDanhSach()
        {
            lbKhachHang.Items.Clear();
            foreach (KhachHang kh in dsKhachHang)
            {
                lbKhachHang.Items.Add(kh.hoten);
            }
        }

        private void EnableButtons()
        {
            btSua.Enabled = true;
            btXemThongTin.Enabled = true;
            btXoa.Enabled = true;
            btXoaHet.Enabled = true;
        }
    }
}
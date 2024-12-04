using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_FORM
{
    public partial class Form1 : Form
    {
             
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Mã Khách Hàng", 100);
            listView1.Columns.Add("Họ Tên", 150);
            listView1.Columns.Add("Giới Tính", 100);
            listView1.Columns.Add("Ngày Sinh", 100);
            listView1.Columns.Add("Số Điện Thoại", 150);
            listView1.Columns.Add("Địa Chỉ", 250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string maKH = txtMaKH.Text.Trim(); // Mã khách hàng
            string hoten = txtHoten.Text.Trim(); // Họ tên
            string gioitinh = GioiTinh1.Checked ? "Nam" : "Nữ"; // Kiểm tra giới tính (Nam hay Nữ)
            string sdt = txtSDT.Text.Trim(); // Số điện thoại
            string diachi = txtDiaChi.Text.Trim(); // Địa chỉ

            // Lấy ngày sinh từ DateTimePicker
            string ngaysinh = NamSinh.Value.ToString("dd/MM/yyyy");  // Nếu bạn dùng DateTimePicker

            // Kiểm tra xem có đủ thông tin không
            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(sdt)
                || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Nếu thiếu thông tin, không thực hiện tiếp
            }

            // Tạo một item mới để thêm vào ListView
            ListViewItem item = new ListViewItem(maKH);  // Mã khách hàng là phần tử chính
            item.SubItems.Add(hoten); // Thêm họ tên
            item.SubItems.Add(gioitinh); // Thêm giới tính
            item.SubItems.Add(ngaysinh); // Thêm ngày sinh
            item.SubItems.Add(sdt); // Thêm số điện thoại
            item.SubItems.Add(diachi); // Thêm địa chỉ

            // Kiểm tra listView1 trước khi thêm
            if (listView1 != null)
            {
                listView1.Items.Add(item);  // Thêm item vào ListView
            }
            else
            {
                MessageBox.Show("ListView chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xóa dữ liệu trong các ô nhập liệu sau khi thêm
            txtMaKH.Clear();
            txtHoten.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();

            // Đặt lại giá trị của DateTimePicker và checkbox
            NamSinh.Value = DateTime.Now;
            GioiTinh1.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        { 
          if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("ListView chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selecteditem = listView1.SelectedItems[0];
            selecteditem.Text = txtMaKH.Text.Trim();
            selecteditem.SubItems[1].Text = txtHoten.Text.Trim();
            selecteditem.SubItems[2].Text = GioiTinh1.Checked ? "Nam" : "Nữ";

            selecteditem.SubItems[3].Text = txtSDT.Text.Trim();

        }
    }
}


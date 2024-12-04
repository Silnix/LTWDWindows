using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiWDFA0402
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog mFileDialog = new OpenFileDialog();
            mFileDialog.Title = "Open Video";
            mFileDialog.Multiselect = false;
            mFileDialog.Filter = "Video files(*.avi)|*.avi|All files|*.*";
            if (mFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = mFileDialog.FileName;
                button2.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wmpKhungHinh.URL = tbDuongDan.Text;
            wmpKhungHinh.Ctlcontrols.play();
            button3.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            wmpKhungHinh.Ctlcontrols.stop();
        }

        private void Chọn_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}


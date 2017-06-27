using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class MainEntrance : Form
    {
        public MainEntrance()
        {
            InitializeComponent();
        }

        private void buttonOpenForm1_Click(object sender, EventArgs e)
        {
            FormInput form = new FormInput();
            form.Show();// 可以新开多个，主窗口还可以获得焦点
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();// 退出当前窗口
            // Application.Exit();// 退出程序
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FormLabel();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "最简单的提示内容",
                "提示的标题",
                MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new FormList();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormInput form = new FormInput();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void weToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click 2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new FormButton();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new FormTab();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var form = new FormListView();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var form = new FormTreeView();
            form.ShowDialog();
        }
    }
}

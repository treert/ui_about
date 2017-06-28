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
    public partial class FormFile : Form
    {
        public FormFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开文件";
            open.FileName = "";
            open.AddExtension = true;// 自动加后缀
            open.CheckFileExists = true;
            open.CheckFileExists = true;
            open.Filter = "文本文件(*.txt)|*.txt;*.lua|哈哈|*.haha";// 
            open.ValidateNames = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(open.FileName, "文件名");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(save.FileName, "文件名");
            }
        }
    }
}

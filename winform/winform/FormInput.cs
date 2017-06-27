using System;
using System.Collections.Generic;// 包含各种容器，常见的List, Dictionary, HashSet, SortedSet
using System.ComponentModel;
using System.Data;// 数据库访问控制
using System.Drawing;// 绘图
using System.Linq;
using System.Text;// 文本
using System.Threading.Tasks;
using System.Windows.Forms;// 窗体和组件

namespace winform
{
    public partial class FormInput : Form
    {
        public string m_key;
        public string m_val;
        public bool m_ok;
        public FormInput()
        {
            InitializeComponent();
            m_key = "";
            m_val = "";
            m_ok = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            m_key = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            m_val = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_ok = true;
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开文件";
            open.FileName = "";
            open.AddExtension = true;// 自动加后缀
            open.CheckFileExists = true;
            open.CheckFileExists = true;
            open.Filter = "文本文件(*.txt)|*.txt;*.lua|哈哈|*.haha";// 
            open.ValidateNames = true;

            if(open.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(open.FileName,"文件名");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(save.FileName, "文件名");
            }
        }
    }
}

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
    public partial class FormListView : Form
    {
        public FormListView()
        {
            InitializeComponent();
        }

        private void FormListView_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("属性");
            listView1.Columns.Add("值");

            listView1.ShowGroups = true;
            listView1.Groups.Add("1","g1");
            listView1.Groups.Add("2", "g2");

            listView1.BeginUpdate();

            Func<string, string, ListViewItem> add_item = (string kk, string vv) =>
            {
                var item = listView1.Items.Add(kk);
                item.SubItems.Add(vv);
                return item;
            };

            add_item("key11", "val1").Group = listView1.Groups[0];
            add_item("key12", "val1").Group = listView1.Groups[1];
            add_item("key13", "val1").Group = listView1.Groups[0];
            add_item("key14", "val1").Group = listView1.Groups[0];

            add_item("key11", "val1").Group = listView1.Groups[1];
            add_item("key12", "val1").Group = listView1.Groups[1];
            add_item("key13", "val1").Group = listView1.Groups[1];

            listView1.EndUpdate();

            listView1.GridLines = true;// 显示表格线
            listView1.View = View.Details;// 显示模式，显示表格细节
            listView1.LabelEdit = false;// 是否可编辑器第一列
            listView1.Scrollable = true;// 滚动条
            listView1.FullRowSelect = true;// 可以选择行
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.ShowGroups = !listView1.ShowGroups;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new FormInput();
            form.ShowDialog();

            if (form.m_ok == false)
                return;


            if(form.m_key != "" && form.m_val != "")
            {
                var item = listView1.Items.Add(form.m_key);
                item.SubItems.Add(form.m_val);
            }
            else
            {
                MessageBox.Show("输入空值");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            //listView1.MultiSelect = false;
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Point pos = new Point(e.X, e.Y);
                contextMenuStrip1.Show(listView1, pos);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
        }

    }
}

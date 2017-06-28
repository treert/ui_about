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
    public partial class FormLabel : Form
    {
        public FormLabel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            linkLabel2.Visible = !linkLabel2.Visible;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                TextBox txt_box = (TextBox)sender;
                string txt = txt_box.SelectedText.Trim();


                if(txt.Length > 0)
                {
                    ContextMenu menu = new ContextMenu();
                    MenuItem menu_item = new MenuItem("choose: " + txt);
                    menu_item.Click += new EventHandler((object sender_, EventArgs e_) =>
                    {
                        MessageBox.Show("click: " + txt);
                    });
                    menu.MenuItems.Add(menu_item);
                    txt_box.ContextMenu = menu;
                }
                else
                {
                    txt_box.ContextMenu = null;
                }
            }
        }
    }
}

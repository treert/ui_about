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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                MessageBox.Show(radioButton1.Text);
            }
            else if(radioButton2.Checked)
            {
                MessageBox.Show(radioButton2.Text);
            }
            else if(radioButton3.Checked)
            {
                MessageBox.Show(radioButton3.Text);
            }
            else
            {
                MessageBox.Show("who");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < checkedListBox1.Items.Count; ++i)
            {
                if (checkedListBox1.GetItemChecked(i))
                    list.Add(i);
            }
            
            MessageBox.Show(string.Join(",", list));
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormTreeView : Form
    {
        public FormTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormTreeView_Load(object sender, EventArgs e)
        {
            //treeView1.Nodes.Clear();
            //treeView1.Nodes.Add("根节点");
            treeView1.ExpandAll();

            treeView1.AllowDrop = true;// 允许拖拽
        }

        int _index = 0;
        void AddChildNode()
        {
            if(treeView1.SelectedNode == null)
            {
                treeView1.Nodes.Add("根节点");
            }
            else
            {
                _index ++;
                TreeNode tmp = new TreeNode();
                tmp.Text = "节点" + _index;
                tmp.Tag = _index;
                treeView1.SelectedNode.Nodes.Add(tmp);
                treeView1.SelectedNode.Expand();
            }
        }

        void AddBrotherNode()
        {
            if (treeView1.SelectedNode == null)
            {
                return;
            }
            else
            {
                if (treeView1.SelectedNode.Parent == null)
                {
                    return;
                }

                _index++;
                TreeNode tmp = new TreeNode();
                tmp.Text = "节点" + _index;
                tmp.Tag = _index;
                treeView1.SelectedNode.Parent.Nodes.Insert(treeView1.SelectedNode.Index + 1, tmp);
            }
        }

        void DeleteNode()
        {
            if(treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Parent == null)
                {
                    return;
                }

                treeView1.SelectedNode.Remove();
            }
        }

        private void 添加节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChildNode();
        }

        private void 添加兄弟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrotherNode();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNode();
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            //if(e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    contextMenuStrip1.Show(treeView1, e.Location);
            //}
        }

        // 实现拖拽子节点
        // > http://visionsky.blog.51cto.com/733317/361894/
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if(e.Item is TreeNode)
            {
                treeView1.DoDragDrop(e.Item, DragDropEffects.Move);
                //(e.Item as TreeNode).BackColor = Color.LightGreen;
            }
            
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            // 和想象的不一样哎
            //if (e.Data.GetDataPresent(typeof(TreeNode)))
            //{
            //    e.Effect = DragDropEffects.Move;

            //    Point pos = new Point(e.X, e.Y);
            //    pos = treeView1.PointToClient(pos);
            //    TreeNode dropNode = treeView1.GetNodeAt(pos);
            //    treeView1.SelectedNode = dropNode;
            //}
            //else
            //    e.Effect = DragDropEffects.None;
        }

        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode myNode = e.Data.GetData(typeof(TreeNode)) as TreeNode;
                myNode.BackColor = Color.LightGreen;

                e.Effect = DragDropEffects.Move;
                Point pos = new Point(e.X, e.Y);
                pos = treeView1.PointToClient(pos);
                TreeNode dropNode = treeView1.GetNodeAt(pos);
                treeView1.SelectedNode = dropNode;
                if(dropNode != null)
                {
                    dropNode.Expand();
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
                
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode myNode = null;
            if(e.Data.GetDataPresent(typeof(TreeNode)))
            {
                myNode = e.Data.GetData(typeof(TreeNode)) as TreeNode;
                myNode.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("error");
                return;
            }
            Point pos = new Point(e.X, e.Y);
            pos = treeView1.PointToClient(pos);
            TreeNode dropNode = treeView1.GetNodeAt(pos);
            if(dropNode == null)
            {
                // 没有目标节点，删掉节点
                if (MessageBox.Show("删掉", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    myNode.Remove();
                }

                return;
            }
            if(dropNode == myNode.Parent || dropNode == myNode)
            {
                return;// 没有变化
            }

            Func<TreeNode, TreeNode, bool> is_ancestor = (TreeNode child, TreeNode ancestor) =>
            {
                int count = 0;
                while(child.Parent != null)
                {
                    count++;
                    if(child.Parent == ancestor)
                    {
                        return true;
                    }
                    child = child.Parent;

                    if(count > 10)
                    {
                        MessageBox.Show("dead loop");
                    }
                }
                return false;
            };
            
            if(is_ancestor(dropNode, myNode))
            {
                return;// 不能复制到儿子身上
            }

            myNode.Remove();
            dropNode.Nodes.Add(myNode);
            dropNode.Expand();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if(e.Node.Parent == null)
                {
                    e.Node.ContextMenuStrip = contextMenuStrip2;
                }
                else
                {
                    e.Node.ContextMenuStrip = contextMenuStrip1;
                }
                
            }
        }

        private void 添加儿子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChildNode();
        }
    }
}

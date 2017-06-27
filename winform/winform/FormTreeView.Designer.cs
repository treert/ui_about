namespace winform
{
    partial class FormTreeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点2", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点12");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点13");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode5,
            treeNode6,
            treeNode7});
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加兄弟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TreeView";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 17);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "节点1";
            treeNode2.Name = "节点8";
            treeNode2.Text = "节点8";
            treeNode3.Name = "节点2";
            treeNode3.Text = "节点2";
            treeNode4.Name = "节点12";
            treeNode4.Text = "节点12";
            treeNode5.Name = "节点3";
            treeNode5.Text = "节点3";
            treeNode6.Name = "节点11";
            treeNode6.Text = "节点11";
            treeNode7.Name = "节点13";
            treeNode7.Text = "节点13";
            treeNode8.Name = "节点0";
            treeNode8.Text = "节点0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(665, 417);
            this.treeView1.TabIndex = 0;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加节点ToolStripMenuItem,
            this.添加兄弟ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 添加节点ToolStripMenuItem
            // 
            this.添加节点ToolStripMenuItem.Name = "添加节点ToolStripMenuItem";
            this.添加节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加节点ToolStripMenuItem.Text = "添加儿子";
            this.添加节点ToolStripMenuItem.Click += new System.EventHandler(this.添加节点ToolStripMenuItem_Click);
            // 
            // 添加兄弟ToolStripMenuItem
            // 
            this.添加兄弟ToolStripMenuItem.Name = "添加兄弟ToolStripMenuItem";
            this.添加兄弟ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加兄弟ToolStripMenuItem.Text = "添加兄弟";
            this.添加兄弟ToolStripMenuItem.Click += new System.EventHandler(this.添加兄弟ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // FormTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 498);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTreeView";
            this.Text = "FormTreeView";
            this.Load += new System.EventHandler(this.FormTreeView_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加兄弟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}
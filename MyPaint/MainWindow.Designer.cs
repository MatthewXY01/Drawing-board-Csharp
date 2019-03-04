namespace MyPaint
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbresize = new System.Windows.Forms.PictureBox();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorBar1 = new MyPaint.ColorBar();
            this.DrawTools = new System.Windows.Forms.ToolStrip();
            this.pencil = new System.Windows.Forms.ToolStripButton();
            this.eraser = new System.Windows.Forms.ToolStripButton();
            this.rect = new System.Windows.Forms.ToolStripButton();
            this.fillrect = new System.Windows.Forms.ToolStripButton();
            this.circle = new System.Windows.Forms.ToolStripButton();
            this.fillcircle = new System.Windows.Forms.ToolStripButton();
            this.tri = new System.Windows.Forms.ToolStripButton();
            this.filltri = new System.Windows.Forms.ToolStripButton();
            this.lines = new System.Windows.Forms.ToolStripButton();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.CurrentSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.MousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.DrawTools.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.clearScreenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.SaveAsToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.fileToolStripMenuItem.Text = "文件(&F)";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "新建(&N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "打开(&O)";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem1
            // 
            this.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1";
            this.SaveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.SaveAsToolStripMenuItem1.Text = "另存为(&A)";
            this.SaveAsToolStripMenuItem1.Click += new System.EventHandler(this.SaveAsToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "保存(&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "退出(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearScreenToolStripMenuItem
            // 
            this.clearScreenToolStripMenuItem.Name = "clearScreenToolStripMenuItem";
            this.clearScreenToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.clearScreenToolStripMenuItem.Text = "清屏(&C)";
            this.clearScreenToolStripMenuItem.Click += new System.EventHandler(this.clearScreenToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbresize);
            this.panel1.Controls.Add(this.picturebox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(64, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 403);
            this.panel1.TabIndex = 1;
            // 
            // pbresize
            // 
            this.pbresize.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbresize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pbresize.Location = new System.Drawing.Point(450, 310);
            this.pbresize.Name = "pbresize";
            this.pbresize.Size = new System.Drawing.Size(5, 5);
            this.pbresize.TabIndex = 1;
            this.pbresize.TabStop = false;
            this.pbresize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbresize_MouseDown);
            this.pbresize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbresize_MouseMove);
            this.pbresize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbresize_MouseUp);
            // 
            // picturebox1
            // 
            this.picturebox1.BackColor = System.Drawing.Color.White;
            this.picturebox1.Location = new System.Drawing.Point(0, 0);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(450, 310);
            this.picturebox1.TabIndex = 0;
            this.picturebox1.TabStop = false;
            this.picturebox1.Paint += new System.Windows.Forms.PaintEventHandler(this.picturebox1_Paint);
            this.picturebox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseDown);
            this.picturebox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseMove);
            this.picturebox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.colorBar1);
            this.panel2.Controls.Add(this.DrawTools);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 403);
            this.panel2.TabIndex = 2;
            // 
            // colorBar1
            // 
            this.colorBar1.Location = new System.Drawing.Point(3, 156);
            this.colorBar1.Name = "colorBar1";
            this.colorBar1.PickColor = System.Drawing.Color.Black;
            this.colorBar1.Size = new System.Drawing.Size(60, 215);
            this.colorBar1.TabIndex = 1;
            // 
            // DrawTools
            // 
            this.DrawTools.AutoSize = false;
            this.DrawTools.BackColor = System.Drawing.Color.White;
            this.DrawTools.Dock = System.Windows.Forms.DockStyle.None;
            this.DrawTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencil,
            this.eraser,
            this.rect,
            this.fillrect,
            this.circle,
            this.fillcircle,
            this.tri,
            this.filltri,
            this.lines});
            this.DrawTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.DrawTools.Location = new System.Drawing.Point(7, 8);
            this.DrawTools.Name = "DrawTools";
            this.DrawTools.Size = new System.Drawing.Size(48, 128);
            this.DrawTools.TabIndex = 0;
            this.DrawTools.Text = "toolStrip1";
            this.DrawTools.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // pencil
            // 
            this.pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pencil.Image = ((System.Drawing.Image)(resources.GetObject("pencil.Image")));
            this.pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(23, 20);
            this.pencil.Text = "铅笔";
            this.pencil.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // eraser
            // 
            this.eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(23, 20);
            this.eraser.Text = "橡皮";
            this.eraser.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // rect
            // 
            this.rect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rect.Image = ((System.Drawing.Image)(resources.GetObject("rect.Image")));
            this.rect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rect.Name = "rect";
            this.rect.Size = new System.Drawing.Size(23, 20);
            this.rect.Text = "空矩形";
            this.rect.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // fillrect
            // 
            this.fillrect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillrect.Image = ((System.Drawing.Image)(resources.GetObject("fillrect.Image")));
            this.fillrect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillrect.Name = "fillrect";
            this.fillrect.Size = new System.Drawing.Size(23, 20);
            this.fillrect.Text = "实矩形";
            this.fillrect.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // circle
            // 
            this.circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(23, 20);
            this.circle.Text = "空圆形";
            this.circle.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // fillcircle
            // 
            this.fillcircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillcircle.Image = ((System.Drawing.Image)(resources.GetObject("fillcircle.Image")));
            this.fillcircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillcircle.Name = "fillcircle";
            this.fillcircle.Size = new System.Drawing.Size(23, 20);
            this.fillcircle.Text = "实圆形";
            this.fillcircle.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // tri
            // 
            this.tri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tri.Image = ((System.Drawing.Image)(resources.GetObject("tri.Image")));
            this.tri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tri.Name = "tri";
            this.tri.Size = new System.Drawing.Size(23, 20);
            this.tri.Text = "空三角形";
            this.tri.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // filltri
            // 
            this.filltri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filltri.Image = ((System.Drawing.Image)(resources.GetObject("filltri.Image")));
            this.filltri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filltri.Name = "filltri";
            this.filltri.Size = new System.Drawing.Size(23, 20);
            this.filltri.Text = "实三角形";
            this.filltri.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // lines
            // 
            this.lines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lines.Image = ((System.Drawing.Image)(resources.GetObject("lines.Image")));
            this.lines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(23, 20);
            this.lines.Text = "直线";
            this.lines.Click += new System.EventHandler(this.DrawTools_Click);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentSize,
            this.MousePosition});
            this.Status.Location = new System.Drawing.Point(0, 428);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(744, 22);
            this.Status.TabIndex = 3;
            this.Status.Text = "statusStrip1";
            // 
            // CurrentSize
            // 
            this.CurrentSize.Name = "CurrentSize";
            this.CurrentSize.Size = new System.Drawing.Size(0, 17);
            // 
            // MousePosition
            // 
            this.MousePosition.Name = "MousePosition";
            this.MousePosition.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " MXYPaint";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbresize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.DrawTools.ResumeLayout(false);
            this.DrawTools.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.PictureBox pbresize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip DrawTools;
        private System.Windows.Forms.ToolStripButton pencil;
        private System.Windows.Forms.ToolStripButton eraser;
        private System.Windows.Forms.ToolStripButton rect;
        private System.Windows.Forms.ToolStripButton fillrect;
        private System.Windows.Forms.ToolStripButton circle;
        private System.Windows.Forms.ToolStripButton fillcircle;
        private System.Windows.Forms.ToolStripButton tri;
        private System.Windows.Forms.ToolStripButton filltri;
        private System.Windows.Forms.ToolStripButton lines;
        private System.Windows.Forms.ToolStripMenuItem clearScreenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Status ;
        private ColorBar colorBar1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel MousePosition;
        private System.Windows.Forms.ToolStripStatusLabel CurrentSize;
    }
}


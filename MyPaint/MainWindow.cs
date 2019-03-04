using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Closing += new CancelEventHandler(MainWindow_Closing);
        }
        private Tools tools;//工具
        private bool PBRESIZE = false;//画布大小改变的状态判断
        private string type;//工具类型
        private Size defaultsize;//初始画布大小
        private string filename;//文件名

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picturebox1.Width, picturebox1.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.FillRectangle(new SolidBrush(picturebox1.BackColor), new Rectangle(0, 0, picturebox1.Width, picturebox1.Height));

            tools = new Tools(this.picturebox1.CreateGraphics(), colorBar1.PickColor, bmp);//实例化工具类
            defaultsize = picturebox1.Size;
            graphics.Dispose();
            CurrentSize.Text = ("画布大小：" + picturebox1.Size.ToString());
        }//加载总窗体时，创建画板，填充以picturebox大小一致的白色矩形，初始化工具tools，设定默认画布大小为picturebox1大小

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出画板？"
                , "MXYPaint", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }//窗体关闭时的提示

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picturebox1.Size = defaultsize;
            pbresize.Location = new Point(defaultsize);
            tools.Clear(picturebox1);
            CurrentSize.Text = ("画布大小：" + picturebox1.Size.ToString());
        }//New 事件

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();//实例化打开文件对话框
            open.Filter = "JPG|*.jpg|BMP|*.bmp|所有文件|*.*";//设置对话框打开文件扩展名
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmpformfile = new Bitmap(open.FileName);
                panel1.AutoScrollPosition = new Point(0, 0);
                picturebox1.Size = bmpformfile.Size;//picturebox1控件大小改变为加载图片的大小
                pbresize.Location = new Point(bmpformfile.Width, bmpformfile.Height);//相应用于调整picturebox1大小的控件的位置移动到新的拐角
                tools.DrawTools_Graphics = picturebox1.CreateGraphics();//因为picturebox1大小的改变，tools的画板也需要重新调整
                Bitmap bmp = new Bitmap(bmpformfile.Width, bmpformfile.Height);//建立一个用于“承载”的位图对象
                Graphics graphics = Graphics.FromImage(bmp);//“虚”的中间画板
                graphics.DrawImage(bmpformfile, 0, 0, bmpformfile.Width, bmpformfile.Height);//承载加载的图片
                graphics.Dispose();
                bmpformfile.Dispose();//释放加载图片资源
                tools.Original = bmp;//tools的初始图设为加载的图片
                tools.DrawTools_Graphics.DrawImage(bmp, 0, 0);
                bmp.Dispose();
                filename = open.FileName;
                open.Dispose();
            }
        }//Load 事件

        private void SaveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                tools.Original.Save(save.FileName);
                filename = save.FileName;
            }
        }//Save As 事件

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename != null)//如果正在处理的图来源于加载图片，则filename是原加载图片名，覆盖即可
            {
                if (MessageBox.Show("Do you want to save changes?", "MXYPaint", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tools.Original.Save(filename);
                }
            }
            else//若为完全自创图，则功能类似于另存为
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    tools.Original.Save(save.FileName);
                    filename = save.FileName;
                }
            }
        }//Save 事件

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出画板？"
            , "MXYPaint", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                tools.ClearVar();
                Application.Exit();
            }     
        }//Exit 事件

        private void clearScreenToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    tools.Clear(picturebox1);
                }//Clear 事件
        
        /*调整画布大小*/
        private void pbresize_MouseDown(object sender, MouseEventArgs e)
        {
            PBRESIZE = true;
        }

        private void pbresize_MouseMove(object sender, MouseEventArgs e)
        {
            if(PBRESIZE==true)
            {
                pbresize.Location = new Point(pbresize.Location.X + e.X, pbresize.Location.Y + e.Y);
            }
        }

        private void pbresize_MouseUp(object sender, MouseEventArgs e)
        {
            PBRESIZE = false;
            picturebox1.Size = new Size(pbresize.Location.X - this.panel1.AutoScrollPosition.X, pbresize.Location.Y - this.panel1.AutoScrollPosition.Y);
            tools.DrawTools_Graphics = picturebox1.CreateGraphics();
            Bitmap bmp = new Bitmap(picturebox1.Width, picturebox1.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.FillRectangle(new SolidBrush(picturebox1.BackColor), new Rectangle(0, 0, picturebox1.Width, picturebox1.Height));
            graphics.DrawImage(tools.Original, 0, 0);
            graphics.Dispose();
            graphics = picturebox1.CreateGraphics();
            graphics.DrawImage(bmp, 0, 0);
            graphics.Dispose();
            tools.Original = bmp;
            bmp.Dispose();
            CurrentSize.Text = ("画布大小：" + picturebox1.Size.ToString());
        }

        /*picturebox上鼠标绘制操作*/
        private void picturebox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                tools.DrawColor = colorBar1.PickColor;
                if(tools!=null)
                {
                    tools.startdraw = true;
                    tools.startpoint = new Point(e.X, e.Y);
                }
            }
        }//鼠标左键按下开始绘制

        private void picturebox1_MouseMove(object sender, MouseEventArgs e)
        {
            MousePosition.Text = ("鼠标位置：" + e.Location.ToString());
            if(tools.startdraw==true)
            {
                switch(type)
                {
                    case "pencil":
                        tools.Pencil(e);
                        break;
                    case "eraser":
                        tools.Eraser(e);
                        break;
                    default:
                        tools.Draw(e, type);
                        break;
                }
            }
        }//绘制图形

        private void picturebox1_MouseUp(object sender, MouseEventArgs e)
        {
            tools.Enddraw(e);
        }//鼠标按键抬起结束绘制

        private void DrawTools_Click(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button != null)
            {
                type = button.Name;
                switch (type)
                {
                    case "eraser":
                        picturebox1.Cursor = new Cursor(Application.StartupPath + @"\img\eraser1.cur");
                        break;
                    case "pencil":
                        picturebox1.Cursor = new Cursor(Application.StartupPath + @"\img\pen_r.cur");
                        break;
                    default:
                        picturebox1.Cursor = new Cursor(Application.StartupPath + @"\img\normal.cur");
                        break;
                }
            }
        }//选择工具图标

        private void picturebox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(tools.Original, 0, 0);
        }//重绘画板

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyPaint
{
    class Triangle
    {
        public PointF [] points=new PointF[3];
        public Triangle(PointF x, PointF y, PointF z)
        {
            points[0] = x;
            points[1] = y;
            points[2] = z;
        }
    }

    class Tools
    {
        public Graphics DrawTools_Graphics;//目标绘图板
        private Pen p;
        private Image originalImg;//原始画布，用来保存已完成的绘图过程
        private Color drawColor = Color.Black;//绘图颜色
        private Graphics newgraphics;//中间画板
        private Image finishingImg;//中间画布，用来保存绘图过程中的痕迹
        public bool startdraw = false;//开始绘制状态判断
        public Point startpoint;//绘制起始点
        public Tools(Graphics g, Color c, Image img)
        {
            DrawTools_Graphics = g;
            drawColor = c;
            p = new Pen(c, 1);
            finishingImg = (Image)img.Clone();
            originalImg = (Image)img.Clone();
        }//构造函数

        public Image Original//为了不破坏封装性，将 originalImg和finishingImg设为私有变量，提供public接口Original 
        {
            get { return originalImg; }
            set
            {
                originalImg = (Image)value.Clone();
                finishingImg = (Image)value.Clone();
            }
        }

        public Color DrawColor//颜料
        {
            get { return drawColor; }
            set
            {
                drawColor = value;
                p.Color = value;
            }
        }

        public void Pencil(MouseEventArgs e)
        {
            if(startdraw==true)
            {
                newgraphics = Graphics.FromImage(finishingImg);
                newgraphics.DrawLine(p, startpoint, e.Location);
                startpoint = e.Location;
                newgraphics.Dispose();
                DrawTools_Graphics.DrawImage(finishingImg, 0, 0);
            }
        }//铅笔工具

        public void Eraser(MouseEventArgs e)
        {
            if(startdraw==true)
            {
                newgraphics = Graphics.FromImage(finishingImg);
                newgraphics.FillRectangle(new SolidBrush(Color.White), e.X, e.Y, 20, 20);
                newgraphics.Dispose();
                DrawTools_Graphics.DrawImage(finishingImg, 0, 0);
            }
        }//橡皮工具

        public void Draw(MouseEventArgs e, string type)
        {
            Image tempImg = (Image)originalImg.Clone();
            newgraphics = Graphics.FromImage(tempImg);

            if(startdraw==true)
            {
                Point refpoint = new Point();
                refpoint.X = startpoint.X < e.X ? startpoint.X : e.X;
                refpoint.Y = startpoint.Y < e.Y ? startpoint.Y : e.Y;
                Size size = new Size(Math.Abs(e.X - startpoint.X), Math.Abs(e.Y - startpoint.Y));
                Rectangle rectangle = new Rectangle(refpoint, size);
                switch(type)
                {
                    case "rect":
                        {
                            newgraphics.DrawRectangle(p, rectangle);
                            break;
                        }
                        
                    case "fillrect":
                        {
                            newgraphics.FillRectangle(new SolidBrush(drawColor), rectangle);
                            break;
                        }
                    case "circle":
                        {
                            newgraphics.DrawEllipse(p, rectangle);
                            break;
                        }
                    case "fillcircle":
                        {
                            newgraphics.FillEllipse(new SolidBrush(drawColor), rectangle);
                            break;
                        }
                    case "tri":
                        {
                            PointF A = new PointF((size.Width + refpoint.X + refpoint.X) / 2, refpoint.Y);
                            PointF B = new PointF(refpoint.X, refpoint.Y + size.Height);
                            PointF C = new PointF(refpoint.X + size.Width, refpoint.Y + size.Height);
                            Triangle triangle = new Triangle(A, B, C);
                            newgraphics.DrawPolygon(p, triangle.points);
                            break;
                        }
                    case "filltri":
                        {
                            PointF A = new PointF((size.Width + refpoint.X + refpoint.X) / 2, refpoint.Y);
                            PointF B = new PointF(refpoint.X, refpoint.Y + size.Height);
                            PointF C = new PointF(refpoint.X + size.Width, refpoint.Y + size.Height);
                            Triangle triangle = new Triangle(A, B, C);
                            newgraphics.FillPolygon(new SolidBrush(drawColor), triangle.points);
                            break;
                        }
                    case "lines":
                        {
                            newgraphics.DrawLine(p, startpoint, e.Location);
                            break;
                        }
                }
                newgraphics.Dispose();
                newgraphics = Graphics.FromImage(finishingImg);
                newgraphics.DrawImage(tempImg, 0, 0);
                newgraphics.Dispose();
                DrawTools_Graphics.DrawImage(tempImg, 0, 0);
                tempImg.Dispose();
            }
        }//其他绘制工具

        public void Enddraw(MouseEventArgs e)
        {
            startdraw = false;
            originalImg = (Image)finishingImg.Clone();
        }//结束绘制操作

        public void Clear(PictureBox pb)
        {
            newgraphics = Graphics.FromImage(originalImg);
            newgraphics.FillRectangle(new SolidBrush(pb.BackColor), 0, 0, pb.Width, pb.Height);
            DrawTools_Graphics.DrawImage(originalImg, 0, 0);
            finishingImg = (Image)originalImg.Clone();
        }//清屏操作

        public void ClearVar()
        {
            DrawTools_Graphics.Dispose();
            originalImg.Dispose();
            finishingImg.Dispose();
            p.Dispose();
        }
    }
}

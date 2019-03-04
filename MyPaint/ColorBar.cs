using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class ColorBar : UserControl
    {
        public ColorBar()
        {
            InitializeComponent();
        }

        private Color color = Color.Black;//color 当前颜色

        public Color PickColor
        {
            get { return color; }
            set
            {
                color = value;
            }
        }//一个设定，返回当前颜色的方法
        //ColorChanged事件相关的定义
        public class ColorChangedEventArgs : EventArgs
        {
            private Color color;
            public ColorChangedEventArgs(Color c)
            {
                color = c;
            }
            public Color GetColor
            {
                get { return color; }
            }
        }//事件数据的类

        public delegate void ColorChangedEventHandler(object sender, ColorChangedEventArgs e);//委托

        public event ColorChangedEventHandler ColorChanged;//定义一个事件

        protected virtual void OnColorChanged(ColorChangedEventArgs e)
        {
            if (ColorChanged != null)
            {
                ColorChanged(this, e);
            }
        }
        
        private void MoreColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                color = colorDialog.Color;
                showcolor.BackColor = color;
                OnColorChanged(new ColorChangedEventArgs(color));
            }
        }//“更多颜色”选项按钮

        private void ColorButton_Click(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if(button!=null)
            {
                color = button.BackColor;
                showcolor.BackColor = color;
                OnColorChanged(new ColorChangedEventArgs(color));
            }
        }//面板上快速选择颜色按钮

        private void Colorpanel_Enter(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p != null)
                p.BorderStyle = BorderStyle.FixedSingle;
        }//鼠标移至颜色选择块儿时的边缘突出效果

        private void Colorpanel_Leave(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p != null)
                p.BorderStyle = BorderStyle.None;
        }

        private void Colorpanel_Click(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p != null)
            {
                color = p.BackColor;
                showcolor.BackColor = color;
                OnColorChanged(new ColorChangedEventArgs(color));
            }
        }//快速选择颜色
    }
}

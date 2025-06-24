using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "그림 그리기 예제";
            this.Size = new Size(400, 300);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Graphics 객체 가져오기
            Graphics g = e.Graphics;

            // 펜과 브러시 생성
            Pen pen = new Pen(Color.Blue, 2);
            Brush brush = new SolidBrush(Color.Red);

            // 직선 그리기
            g.DrawLine(pen, 10, 10, 200, 10);

            // 사각형 그리기
            g.DrawRectangle(pen, 50, 50, 100, 50);

            // 채워진 원 그리기
            g.FillEllipse(brush, 200, 100, 50, 50);

            // 텍스트 그리기
            Font font = new Font("Arial", 12);
            g.DrawString("Hello, C#!", font, Brushes.Black, new PointF(10, 150));
        }
    }
}

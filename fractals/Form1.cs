using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fractals
{
    public partial class Form1 : Form
    {
        private byte _state = (byte)States.NotEvent;

      //need delegate
        public Form1()
        {
            InitializeComponent();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView1.SelectedNode.Name)
            {
                case "SlavesFractalTree":
                    _state = 1;
                    break;
                case "SlavesFractalTriangle":
                    _state = 2;
                    break;
                default:
                    _state = 0;
                    break;
            }
            pictureBoxUpdate();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (_state)
            {
                case (byte)States.TreeFractal:
                    DrawTree(pictureBox1.Width / 2, 0, 100, 0);
                    break;
                case (byte)States.TringleFractal:
                    printPictureTrigle();
                    break;
                default:
                    break;
            }
        }

        private void pictureBoxUpdate()
        {
            pictureBox1.Update();
            pictureBox1.Refresh();
        }

        private void DrawTree(float x, float y, float lenght, double angle)
        {
            Bitmap map = new Bitmap(pictureBox1.Width, pictureBox1.Height);//Подключаем Битмап
            Graphics g = Graphics.FromImage(map); //Подключаем графику
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//Включаем сглаживание
            Pen p = new Pen(Color.Black);  //Зеленая ручка

            double x1 = x + lenght * Math.Sin(angle * Math.PI * 2 / 360.0);
            double y1 = y + lenght * Math.Cos(angle * Math.PI * 2 / 360.0);
            g.DrawLine(p, x,pictureBox1.Height-y, (float)x1, pictureBox1.Height - (float)y1);
            
            if (lenght > 40)
            { 
                DrawTree((float)x1, (float)y1, (float)(lenght /1.2),angle + 30);
                DrawTree((float)x1, (float)y1, (float)(lenght / 1.2), angle - 30);
                DrawTree((float)x1, (float)y1, (float)(lenght / 1.2), angle + 15);
                DrawTree((float)x1, (float)y1, (float)(lenght / 1.2), angle - 15);
            }
            pictureBox1.BackgroundImage = map;
        }






        private void printPictureTrigle()
        {
            int iter = 6;
            Bitmap map   = new Bitmap(pictureBox1.Width, pictureBox1.Height);//Подключаем Битмап
            Graphics g  = Graphics.FromImage(map); //Подключаем графику
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//Включаем сглаживание
            Pen p = new Pen(Color.Black);  //Зеленая ручка
          //  g.Clear(Color.Black);      //Черный фон

            //Присваеваем размеры picturebox в отдельные переменные, для простоты обращения
            int h = pictureBox1.Height;
            int w = pictureBox1.Width;

            //Выберем начальные точки
            PointF A = new PointF(w * 3 / 4, h * 3 / 4);
            PointF B = new PointF(w / 4, h * 3 / 4);
            PointF C = new PointF(w / 2, h / 4);


            //Рисуем изначальный треугольник
            g.DrawLine(p, A.X, A.Y, B.X, B.Y);
            g.DrawLine(p, B.X, B.Y, C.X, C.Y);
            g.DrawLine(p, A.X, A.Y, C.X, C.Y);


            //Вызываем рекурсивную функцию отрисовки фрактала
            drawMCTriangle(A, B, C, iter, g, p);

            //Переносим изображение из битмапа на picturebox
            pictureBox1.BackgroundImage = map;

        }

        //Рекурсивная функция отрисовки фрактала
        public void drawMCTriangle(PointF A, PointF B, PointF C, int iter, Graphics g, Pen p)
        {
            //Параметры: точки А В С начального треугольника и кол-во итераций iter

            //База рекурсии
            if (iter == 0) //если итераций 0 - то выход
                return;

            PointF D = new PointF();    //Точка центра масс
            PointF v1 = new PointF();   //Вектор AB
            PointF v2 = new PointF();   //Вектор AC

            //Вектор АB
            v1.X = B.X - A.X;
            v1.Y = B.Y - A.Y;

            //Вектор AC
            v2.X = C.X - A.X;
            v2.Y = C.Y - A.Y;

            D.X = A.X + (v1.X + v2.X) / 3;     //К точке А прибавим сумму векторов AВ и AC, деленную на 3
            D.Y = A.Y + (v1.Y + v2.Y) / 3;     //и получим координаты центра масс

            g.DrawLine(p, A.X, A.Y, D.X, D.Y);    //Рисуем отрезки от вершин к центру масс
            g.DrawLine(p, B.X, B.Y, D.X, D.Y);
            g.DrawLine(p, C.X, C.Y, D.X, D.Y);

            drawMCTriangle(A, B, D, iter - 1,g,p);    //Вызываем рекурсивно процендуру для полученных 
            drawMCTriangle(B, C, D, iter - 1, g, p);    //треугольников, с итерацией, меньшей на 1
            drawMCTriangle(A, C, D, iter - 1, g, p);


        }




        [Flags]
        enum States : byte
        { 
            NotEvent=0,
            TreeFractal = 1,
            TringleFractal=2
        
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Structs;

namespace Polygom1._2
{
    /// <summary>
    /// Форма для создания нового многоугольника
    /// </summary>
    public partial class PolygonForm : Form
    {
        Form1 f1;
        public PolygonForm(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        // Метод для очистки содержимого всех полей формы
        public void ClearAllProc()
        {
            X.Text = null;
            Y.Text = null;
            PointBox.Text = null;
        }

        MyPoint point;                                          // Точка для проверки
        Point[] points;                                         // Массив точек вершин

        // Кнопка подтверждения
        private void OK_Click(object sender, EventArgs e)
        {
            string[] str1 = X.Text.Split(',');                  // Массив координат "X" в формате string
            string[] str2 = Y.Text.Split(',');                  // Массив координат "Y" в формате string
            int[] Xs = new int[str1.Length];                    // Создание массива для хранения координат X
            int[] Ys = new int[str1.Length];                    // Массив для Y
            points = new Point[str1.Length];                    // Определение размера массива точек

            //Заполнение массива точек с помощью массивов координат заранее преобразуя string в int
            for (int i = 0; i < str1.Length; i++)
            {
                Xs[i] = int.Parse(str1[i]);
                Ys[i] = int.Parse(str2[i]);
                points[i].X = Xs[i];
                points[i].Y = Ys[i];
            }
            Polygon polygon = new Polygon(Xs, Ys);                          // Создание экземпляра класса Polygon
            // Создание точки для проверки, используя введенные координаты
            string[] pointStr = PointBox.Text.Split(',');                   
            int x = int.Parse(pointStr[0]);
            int y = int.Parse(pointStr[1]);
            point = new MyPoint(x, y);
            f1.Result.Text = polygon.isCollide(polygon, point).ToString();  // Вывод результата проверки
            using (Graphics g = CreateGraphics())
            {
                g.DrawPolygon(Pens.Black, points);
            }
        }
    }
}

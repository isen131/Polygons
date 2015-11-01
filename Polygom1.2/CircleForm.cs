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
    public partial class CircleForm : Form
    {
        private Form1 f1;

        public CircleForm(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        // Кнопка подтверждения создания окружности
        private void button1_Click(object sender, EventArgs e)
        {
            // Задание точки центра окружности
            string[] s = CircleCentre.Text.Split(',');              
            int x1 = int.Parse(s[0]);
            int y1 = int.Parse(s[1]);
            MyPoint p = new MyPoint(x1, y1);
            int r = int.Parse(Radius.Text);                     // Задание радиуса
            // Создание точки для проверки
            string[] pointStr = PointBox.Text.Split(',');   
            int x = int.Parse(pointStr[0]);
            int y = int.Parse(pointStr[1]);
            MyPoint point = new MyPoint(x, y);
            Circle circle = new Circle(p, r);                   // Создание окружности соответсвующей введенным данным
            f1.Result.Text = circle.isCollide(point).ToString();// Вывод результата
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    /// <summary>
    /// Класс для точки
    /// </summary>
    public class MyPoint
    {
        public double x;
        public double y;
        public MyPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //Нахождение расстояния меджу двумя точками 
        public static double Distance(MyPoint p1, MyPoint p2)
        {
            return Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
        }
    } 

    /// <summary>
    /// Класс для круга
    /// </summary>
    public class Circle
    {
        public MyPoint center;
        public float rad;
        public Circle(MyPoint c, int r)
        {
            center = c;
            rad = r;
        }

        public bool isCollide(MyPoint p)          
        {
            //Условие: находится ли точка внутри или на поверхности круга
            if (MyPoint.Distance(center, p) <= rad)
                return true;
            else
                return false;
        }
    }

    /// <summary>
    /// Класс для многоугольника
    /// </summary>
    public class Polygon
    {
        public MyPoint[] points;                             // Массив точек класса MyPoint
        public int pointnumber;                              // Количество точек
        public Polygon(int[] Xs, int[] Ys)                   // Конструктор класса Polygon
        {
            pointnumber = Xs.Length;                         // Задание значений основных полей массива
            points = new MyPoint[pointnumber];
            for (int i = 0; i < Xs.Length; i++)
            {
                points[i] = new MyPoint(Xs[i], Ys[i]);
            }
        }
        public void MyRound(double[] smallAreas)            // Округление чисел
        {
            for (int i = 0; i < pointnumber; i++)
            {
                smallAreas[i] = Math.Round(smallAreas[i], 2);
            }
        }
        public bool isCollide(Polygon polygon, MyPoint p)       // Метод определения принадлежности точек к многоугольнику
        {
            double bigArea;                                     // Площадь заданного многоугольника
            double[] smallAreas = new double[pointnumber];      // Площади треугольников
            double[] ps = new double[pointnumber];              // Полупериметры для треугольников
            double[] dists = new double[points.Length * 2];     // Массив расстоянии между точками

            for (int i = 0; i < points.Length - 1; i++)         // Нахождение расстоянии между двумя точками
            {
                dists[i] = MyPoint.Distance(points[i], points[i + 1]);
            }
            dists[points.Length - 1] = MyPoint.Distance(points[points.Length - 1], points[0]);

            for (int i = 0; i < points.Length; i++)             //
            {
                dists[points.Length + i] = MyPoint.Distance(points[i], p);
            }

            for (int i = 0; i < points.Length - 1; i++)         // Нахождение полупериметров треугольников
            {
                ps[i] = (dists[i] + dists[i + points.Length] + dists[i + points.Length + 1]) / 2;
            }
            ps[pointnumber - 1] = (dists[pointnumber - 1] + dists[pointnumber] + dists[pointnumber * 2 - 1]) / 2;

            //Нахождение площади основного многоугольника
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < pointnumber - 1; i++) 
            {
                sum1 += points[i].x * points[i + 1].y;
            }
            sum1 += points[pointnumber-1].x * points[0].y;

            for (int i = 0; i < pointnumber - 1; i++)
            {
                sum2 += points[i].y * points[i + 1].x;
            }
            sum2 += points[pointnumber - 1].y * points[0].x;
            bigArea = Math.Abs(sum1 - sum2) / 2;

            for (int i = 0; i < pointnumber - 1; i++)       // Нахождение площадей треугольников
            {
                smallAreas[i] = Math.Sqrt(ps[i] * (ps[i] - dists[i]) * (ps[i] - dists[i + points.Length]) * (ps[i] - dists[i + points.Length + 1]));
            }
            smallAreas[pointnumber - 1] = Math.Sqrt(ps[pointnumber - 1] * (ps[pointnumber - 1] - dists[pointnumber - 1]) * (ps[pointnumber - 1] - dists[pointnumber]) * (ps[pointnumber - 1] - dists[pointnumber * 2 - 1]));

            MyRound(smallAreas);
            double sumSmallAreas = 0;                       // Сумма площадей треугольников
            for (int i = 0; i < pointnumber; i++)
            {
                sumSmallAreas += smallAreas[i];
            }

            if(bigArea == sumSmallAreas)                    // Сравнение площадей
                return true;
            else
                return false;
        }
    }
}

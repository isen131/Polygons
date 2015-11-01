using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structs;

namespace Poligin_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Точка
            Console.WriteLine("Введите координаты точки: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            MyPoint point = new MyPoint(x, y);
            //Окружность
            #region
            Console.WriteLine("Введите координаты окружности: ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус: ");
            int r = int.Parse(Console.ReadLine());

            Circle circle = new Circle(new MyPoint(x1, y1), r);
            Console.WriteLine(circle.isCollide(point).ToString());
            #endregion

            //Полигон
            Console.WriteLine("Введите количество вершин: ");
            //Polygon polygon = new Polygon(int.Parse(Console.ReadLine()));
            //Console.WriteLine(polygon.isCollide(polygon, point).ToString());
            Console.ReadKey();
        }
    }
}

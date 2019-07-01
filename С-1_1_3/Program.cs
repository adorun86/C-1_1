using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_1_1_3
{
    class Program
    {
        //машканцев
        //а) Написать программу, которая подсчитывает расстояние между точками с 
        //координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);

        static void Main(string[] args)
        {
            float x1 = 1f;
            float y1 = 1f;
            float x2 = 10f;
            float y2 = 10f;
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("{0:F}", r);

            Console.ReadKey();
        }

       
    }
}

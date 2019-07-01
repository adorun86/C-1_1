using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_1._2
{
    class Program
    {
        //машканцев
        //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
        //по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

        static void Main(string[] args)
        {

            Console.WriteLine("напишите рост");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("напишите вес");
            double weight = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / ((height * height)/10000);// поставил 10000 чтоб рост вводили в см

            Console.WriteLine("Индекс массы тела равен: " + BMI);

            Console.ReadKey();
        }
    }
}

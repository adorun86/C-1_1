using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_1
{
    //машканцев
//   1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//  а) используя склеивание;
//  б) используя форматированный вывод;
//	в) используя вывод со знаком $.
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("напишите имя");
            string name = Console.ReadLine();
            Console.WriteLine("напишите фамилию");
            string lastname = Console.ReadLine();
            Console.WriteLine("напишите возвраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("напишите рост");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("напишите вес");
            int weight = Convert.ToInt32(Console.ReadLine());

            string output;
            //задание 1.а
            //output = " имя: " + name + " фамилия: " + lastname + " возвраст: " + age + " рост: " + height + " вес: " + weight;
            //задание 1.б
            //output = String.Format("имя: {0} фамилия: {1} возвраст: {2} рост:{3} вес:{4}",
            //задание 1.в
            //output = $"имя {name} фамилия {lastname } возвраст {age } рост {height } вес { weight}";
            //            name,
            //            lastname,
            //            age,
            //            height,
            //            weight);

            //Console.WriteLine(output);

            Console.ReadKey();

        }
    }
}


using System;
using System.Text;

namespace _1._1._01._7._54
{
    class Program
    {  
        static void Main(string[] args)
        {   var random = new  Random();
            Console.OutputEncoding = Encoding.Default;
            Console.WriteLine("Введіть кількість чисел:");
            int[] Arrey = new int[int.Parse(Console.ReadLine())];
            for (var i = 0; i<Arrey.Length; i++)
            {
                Arrey[i] = random.Next(0, 1000);
            }
            Array.Sort(Arrey);
            Array.Reverse(Arrey);
            Console.WriteLine("Найбільше значення масиву:" + Arrey[0]);
            Console.WriteLine("Найменше значення масиву:" + Arrey[Arrey.Length - 1]);
            //Console.WriteLine("Массив:");
            //int b = 0;
            //foreach (var number in Arrey)
            //{

            //    Console.WriteLine(Arrey[b]);
            //    b++;
            //}
            Console.ReadLine();




         













            Console.ReadLine();
        }
    }
}

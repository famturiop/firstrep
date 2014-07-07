using System;                       //
using System.Collections.Generic;   //
using System.Linq;                  //подключение библиотек 
using System.Text;                  //
using System.Threading.Tasks;       //

namespace обучалка                  //пространство имён
{
    class Program                   //исходный класс. просто он тут есть и пока не стоит заморачиваться
    {
        static void Main(string[] args)     //метод мэин. это точка входа в программу. программа начинает своё выполнение с первой строчки мэина
        {
            Console.WriteLine("введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ведите эл-ты");
            int[] array = new int[n];
            for (int i = 0; i < n-1; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            met(array, n);
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

        static void met(int[] array1, int b1)  
        {
            for (int i = 0; i < b1 - 1; i++)  
            {
                int min = array1[i];
                for (int j = i + 1; j < b1 - 1; j++)
                {
                    if (array1[j] < min)
                    {
                        int x = array1[j];
                        array1[j] = min;
                        min = x;
                    }    
                }
            }
        }  
    }
}


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyArr
    {
        int[] arr;
        public int Length;

        public MyArr(int Size)
        {
            arr = new int[Size];
            Length = Size;
            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < Length)
                    return arr[index];
                else
                    Console.WriteLine("Индекс выходит за пределы массива!");
                return 0;
            }

            set
            {
                if (index >= 0 && index < Length)
                    arr[index] = value;
                else
                    Console.WriteLine("Индекс выходит за пределы массива!");
            }
        }

        public int this[double index]
        {
            get
            {
                int i = (int)Math.Round(index);
                if (i >= 0 && i < Length)
                    return arr[i];
                else
                    Console.WriteLine("Индекс выходит за пределы массива!");
                return 0;
            }

            set
            {
                int i = (int)Math.Round(index);
                if (i >= 0 && i < Length)
                    arr[i] = value;
                else
                    Console.WriteLine("Индекс выходит за пределы массива!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину для нового массива");
            int MassLength = Convert.ToInt32(Console.ReadLine());
            MyArr UserArray = new MyArr(MassLength);
            while (true)
            {
                Console.WriteLine("Какой элемент вывести (-1 для завершения)");
                double UserInput = Convert.ToDouble(Console.ReadLine());
                if (UserInput == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(UserArray[UserInput]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < UserArray.Length; i++)
            {
                Console.WriteLine(UserArray[i]);
            }
        }
    }
}

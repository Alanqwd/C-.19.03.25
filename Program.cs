using System.Text;

namespace C_._19._03._25
{
    internal class Program
    {
        /*  public enum Seasons
          {
              NotFound = 404, Spring, Winter, Summer // перечисление
          }*/
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // ЧИСЛЕННЫЕ ТИПЫ:
            // int - целое число
            // long - большое целое число
            // float - число с плавающей точкой
            // double -  число с плавающей точкой
            // decimal - число с плавающей точкой
            // byte - от 0 до 255
            // short - маленькое целое число 
            // ЛОГИЧЕСКИЙ ТИП:
            // bool - t or f
            // char - символьный тип
            // string - строковый тип данных.Является ссылочным(класс)


            // int num;
            // f d m - литералы
            // float s = 0.6f;
            // double b = 1.0;
            // decimal c = 4.5m;
            // Console.WriteLine("efefe"); с переносом строки
            //  Console.Write("efefe"); без переноса строки
            // string asd = Console.ReadLine(); // тип - nullable


            // тернарный оператор: ?
            //  int num = 0;
            //  int anotherMum = num > 0 ? 1 : 0;// 1 - true, 0 - false
            //
            //пример на if:
            //  if (num > 0)
            //   {
            //      anotherMum = 1;
            //   }
            //  else anotherMum = 0;


            // циклы: for, while, do.... while, foreach
            // float a = 1.0f;
            // double b = a;
            // b = (double)a;

            //  int a = Convert.ToInt32(Console.ReadLine()); // преобразование с int на string

            // если у вас есть вопросы по коду надо идти на сайт metanit

            //  int[] ints = new int[9];

            // многомерный массив
            //  int[,] matrix = new int[3, 3];

            // зубчатый массив
            // int[][] ints1 = new int[2][];
            // ints1[0] = new int[10];
            //  ints1[1] = new int[12];

            /* int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

             foreach (var item in ints)
             {
                 if (item % 2 == 0)
                 {
                     Console.WriteLine(item);
                 }
             }
            */

            /* string str = "asd";
              string str1 = "asd2";

              Console.WriteLine(str1 + " " + str); // конкретизация строк

              foreach (var item in str1)
              {

              }*/

            /*StringBuilder sd = new StringBuilder();

            int a = 10;

            Console.WriteLine($"Пемеренная a = {a}");*/

            int[] arr = { -3, 1, 3, 45, 69, -1, -11, 0 };

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                while (left < right && arr[left] < 0) {
                    left++;
                    while(left < right && arr[right] >= 0)
                    {
                        if(left < right)
                        {
                            int temp = arr[left];
                            arr[left] = arr[right]; 
                            arr[right] = temp;
                        }
                    }
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item);    
                    }
            }


        }
    }
}

using System;

namespace Homework_4._2
{
   internal class TwoDimensionalArray
   {
      public static int SizeRow()
      {
         int n;
         do
         {
            Console.WriteLine("Введите количество строк массива А");
            int.TryParse(Console.ReadLine(), out n);
            //n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0 || n > 20)
            {
               Console.WriteLine("Введено не верное значение");
            }
         } while (n <= 0 || n > 20);

         return n;
      }

      public static int SizeColumn()
      {
         int m;
         do
         {
            Console.WriteLine("Введите количество столбцов массива А");
            int.TryParse(Console.ReadLine(), out m);
            //m = Convert.ToInt32(Console.ReadLine());
            if (m <= 0 || m >= 20)
            {
               Console.WriteLine("Введено не верное значение");
            }
         } while (m <= 0 || m >= 20);

         return m;
      }
   }
}
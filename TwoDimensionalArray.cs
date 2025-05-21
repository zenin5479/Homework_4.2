using System;
using System.IO;
using System.Text;

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
            if (m <= 0 || m > 20)
            {
               Console.WriteLine("Введено не верное значение");
            }
         } while (m <= 0 || m > 20);

         return m;
      }

      public static double[,] InputArray(double[,] inputArray, int n, int m)
      {
         double[,] outputArray = new double[n, m];
         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < m; j++)
            {
               outputArray[i, j] = inputArray[i, j];
               //Console.Write("{0:f2} ", outputArray[i, j]);
               //Console.Write("{0:f} ", outputArray[i, j]);
               Console.Write("{0} ", outputArray[i, j]);
            }
            Console.WriteLine();
         }

         return outputArray;
      }

      public static void FileWriteString(double[] arrayRealNumbers)
      {
         // Объединение одномерного массива максимальных значений строк double[]
         // в одномерный массив строк string[] для записи в файл (в одну строку массива)
         Console.WriteLine("Одномерный массив строк");
         Console.BackgroundColor = ConsoleColor.DarkBlue;
         StringBuilder stringModified = new StringBuilder();
         int row = 0;
         while (row < arrayRealNumbers.GetLength(0))
         {
            if (row != arrayRealNumbers.GetLength(0) - 1)
            {
               stringModified.Append(arrayRealNumbers[row] + " ");
            }
            else
            {
               stringModified.Append(arrayRealNumbers[row]);
            }

            row++;
         }

         Console.Write(stringModified);
         Console.ResetColor();
         Console.WriteLine();
         // Запись массива строк в файл
         Console.WriteLine("Запись массива строк в файл");
         string filePath = AppContext.BaseDirectory + "b.txt";
         string[] arrayString = { stringModified.ToString() };

         File.WriteAllLines(filePath, arrayString);
      }

      public static void FileWriteArray(double[] arrayRealNumbers)
      {
         // Объединение одномерного массива максимальных значений строк double[]
         // в одномерный массив строк string[] для записи в файл
         Console.WriteLine("Одномерный массив строк");
         StringBuilder stringModified = new StringBuilder();
         string[] arrayString = new string[arrayRealNumbers.GetLength(0)];
         int row = 0;
         while (row < arrayRealNumbers.GetLength(0))
         {
            stringModified.Append(arrayRealNumbers[row]);
            string subLine = stringModified.ToString();
            arrayString[row] = subLine;
            Console.WriteLine(subLine);
            stringModified.Clear();
            row++;
         }

         // Запись массива строк в файл
         Console.WriteLine("Запись массива строк в файл");
         string filePath = AppContext.BaseDirectory + "c.txt";
         File.WriteAllLines(filePath, arrayString);
      }
   }
}
using System;
using System.IO;
using System.Text;

// Составить подпрограмму для решения первой подзадачи и использовать её при решении второй подзадачи
// Во многих задачах возможны два варианта:
// в рассматриваемой строке (столбце) всегда имеется хотя бы один искомый элемент, тогда это ситуация обычного решения;
// в рассматриваемой строке (столбце) отсутствуют искомые элементы,
// тогда это ситуация особого решения (следует выдать об этом сообщение и прекратить выполнение программы)
// Для двумерного массива A из m строк и n столбцов сформировать массив B из m элементов
// Каждый элемент Bi получает значение максимального элемента i–й строки массива A
// Для поиска максимального элемента в произвольной строке двумерного массива использовать подпрограмму
// LibraryForTwoDimensionalArray
// 1 Читаем файл полностью, получаем количество строк и количество столбцов двумерного массива из консоли (+)
// 2 Конвертируем полученный двумерный массив строк string[,] в двумерный массив double[,] и печатаем его в консоль (+)
// 3 Создаем одномерный массив размерности равный количеству строк (+)
// 4 Проводим поиск наибольшего элемента строки двумерного массива double[,] и заполняем одномерный массив результатами (+)
// 5 Сохраняем полученный одномерный массив в файл (распечатываем его в консоль) (+)

namespace Homework_4._2
{
   internal class Program
   {
      static void Main(string[] args)
      {
         // Переводит (,) в (.)
         //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

         int n = TwoDimensionalArray.SizeRow();
         int m = TwoDimensionalArray.SizeColumn();
         string filePath = AppContext.BaseDirectory + "a.txt";
         double[,] arraySearch = TwoDimensionalArray.VvodArray(filePath, n, m);
         double[] arrayMax = TwoDimensionalArray.FindMax(arraySearch);
         VivodArray(arrayMax);
         Console.WriteLine();
         //TwoDimensionalArray.FileWriteArray(arrayMax);
         TwoDimensionalArray.FileWriteString(arrayMax);

         Console.ReadKey();
      }

      
      private static double[] FindMax(double[,] inputArray)
      {
         // Поиск максимального элемента строки (без флагов bool)
         double[] arrayMax = new double[inputArray.GetLength(0)];
         int rowOut = 0;
         int columnOut = 0;
         while (rowOut < inputArray.GetLength(0))
         {
            // Cчитаем, что максимум - это первый элемент строки
            double maxOut = inputArray[rowOut, 0];
            while (columnOut < inputArray.GetLength(1))
            {
               if (maxOut < inputArray[rowOut, columnOut])
               {
                  maxOut = inputArray[rowOut, columnOut];
               }

               columnOut++;
            }

            arrayMax[rowOut] = maxOut;
            //Console.WriteLine("Максимум в строке {0} равен: {1}", rowOut, maxOut);
            columnOut = 0;
            rowOut++;
         }

         return arrayMax;
      }

      private static void VivodArray(double[] inputArray)
      {
         Console.WriteLine("Массив максимальных значений строк");
         int indexMax = 0;
         while (indexMax < inputArray.Length)
         {
            Console.Write("{0} ", inputArray[indexMax]);
            indexMax++;
         }
      }
   }

   //int main()
   //{
   //   int n = razmerrowvect(); +
   //   int m = razmercolumnvect(); +
   //   vvod_vect(a, n, m, fp_a); + ?
   //   find_max(b, a, n, m, fl); + ?
   //   vivod_vector(b, n, fp_finish); + ?
   //}
}
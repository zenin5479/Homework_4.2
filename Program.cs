using System;

// Составить подпрограмму для решения первой подзадачи и использовать её при решении второй подзадачи
// Во многих задачах возможны два варианта:
// в рассматриваемой строке (столбце) всегда имеется хотя бы один искомый элемент, тогда это ситуация обычного решения;
// в рассматриваемой строке (столбце) отсутствуют искомые элементы,
// тогда это ситуация особого решения (следует выдать об этом сообщение и прекратить выполнение программы)
// Для двумерного массива A из m строк и n столбцов сформировать массив B из m элементов
// Каждый элемент Bi получает значение максимального элемента i–й строки массива A
// Для поиска максимального элемента в произвольной строке двумерного массива использовать подпрограмму
// LibraryForTwoDimensionalArray

namespace Homework_4._2
{
   internal class Program
   {
      static void Main(string[] args)
      {
         // Переводит (,) в (.)
         //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

         string filePath = AppContext.BaseDirectory + "a.txt";
         int n = TwoDimensionalArray.SizeRow();
         int m = TwoDimensionalArray.SizeColumn();
         double[,] arraySearch = TwoDimensionalArray.VvodArray(filePath, n, m);
         double[] arrayMax = TwoDimensionalArray.FindMax(arraySearch);
         TwoDimensionalArray.VivodArray(arrayMax);
         Console.WriteLine();
         TwoDimensionalArray.FileWriteString(arrayMax);
         //Console.WriteLine();
         //TwoDimensionalArray.FileWriteArray(arrayMax);

         Console.ReadKey();
      }
   }
}
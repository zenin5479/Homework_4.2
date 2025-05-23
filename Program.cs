using System;
using LibraryFor2DArray;

// Составить подпрограмму для решения первой подзадачи и использовать её при решении второй подзадачи
// Во многих задачах возможны два варианта:
// в рассматриваемой строке (столбце) всегда имеется хотя бы один искомый элемент, тогда это ситуация обычного решения;
// в рассматриваемой строке (столбце) отсутствуют искомые элементы,
// тогда это ситуация особого решения (следует выдать об этом сообщение и прекратить выполнение программы)
// Для двумерного массива A из m строк и n столбцов сформировать массив B из m элементов
// Каждый элемент Bi получает значение максимального элемента i–й строки массива A
// Для поиска максимального элемента в произвольной строке двумерного массива использовать подпрограмму
// LibraryFor2DArray

namespace Homework_4._2
{
   internal class Program
   {
      static void Main()
      {
         // Переводит (,) в (.)
         //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

         int n = VariousMethods.SizeRow();
         int m = VariousMethods.SizeColumn();
         double[,] arrayDouble = VariousMethods.VvodArray(n, m);
         Console.WriteLine();
         double[,] arraySearch = VariousMethods.InputArray(arrayDouble, n, m);
         Console.WriteLine();
         double[] arrayMax = VariousMethods.FindMax(arraySearch);
         Console.WriteLine();
         string[] stringArray = VariousMethods.VivodStringArray(arrayMax);
         Console.WriteLine();
         VariousMethods.FileWriteString(stringArray);
         //Console.WriteLine();
         //string[] arrayString = VariousMethods.VivodArrayString(arrayMax);
         //Console.WriteLine();
         //VariousMethods.FileWriteArray(arrayString);

         Console.ReadKey();
      }
   }
}
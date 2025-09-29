using System;

// Составить подпрограмму для решения первой подзадачи и использовать её при решении второй подзадачи
// Во многих задачах возможны два варианта:
// в рассматриваемой строке (столбце) всегда имеется хотя бы один искомый элемент, тогда это ситуация обычного решения;
// в рассматриваемой строке (столбце) отсутствуют искомые элементы,
// тогда это ситуация особого решения (следует выдать об этом сообщение и прекратить выполнение программы)
// Для двумерного массива A из m строк и n столбцов сформировать массив B из m элементов
// Каждый элемент Bi получает значение максимального элемента i–й строки массива A
// Для поиска максимального элемента в произвольной строке двумерного массива использовать подпрограмму

namespace Homework_4._2
{
   internal class Program
   {
      static void Main()
      {
         // Переводит (,) в (.)
         //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

         int n = MethodsForArray.SizeRow();
         int m = MethodsForArray.SizeColumn();
         double[,] arrayDouble = MethodsForArray.VvodArray(n, m);
         Console.WriteLine();
         double[,] arraySearch = MethodsForArray.InputArray(arrayDouble, n, m);
         Console.WriteLine();
         double[] arrayMax = MethodsForArray.FindMax(arraySearch);
         Console.WriteLine();
         string[] stringArray = MethodsForArray.VivodStringArray(arrayMax);
         Console.WriteLine();
         MethodsForArray.FileWriteString(stringArray);
         Console.WriteLine();
         string[] arrayString = MethodsForArray.VivodArrayString(arrayMax);
         Console.WriteLine();
         MethodsForArray.FileWriteArray(arrayString);

         Console.ReadKey();
      }
   }
}
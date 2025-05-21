using System;
using System.Collections.Generic;
using System.IO;

// Составить подпрограмму для решения первой подзадачи и использовать её при решении второй подзадачи
// Во многих задачах возможны два варианта:
// в рассматриваемой строке (столбце) всегда имеется хотя бы один искомый элемент, тогда это ситуация обычного решения;
// в рассматриваемой строке (столбце) отсутствуют искомые элементы,
// тогда это ситуация особого решения (следует выдать об этом сообщение и прекратить выполнение программы)
// Для двумерного массива A из m строк и n столбцов сформировать массив B из m элементов
// Каждый элемент Bi получает значение максимального элемента i–й строки массива A
// Для поиска максимального элемента в произвольной строке двумерного массива использовать подпрограмму
// LibraryForTwoDimensionalArray
// 1 Получаем количество строк и количество столбцов двумерного массива из консоли
// 2 Читаем файл полностью конвертируем полученный двумерный массив в double и заполняем нужный двумерный массив, печатаем его в консоль
// 3 Создаем одномерный массив размерности равный количеству строк
// 4 Проводим поиск наибольшего элемента строки двухмерного массива и заполняем одномерный массив результатами
// 5 Сохраняем полученный одномерный массив в файл (распечатываем его в консоль)

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
         
         

         Console.ReadKey();
      }

      private static void InputArray(double[,] a, int n, int m, FileStream fpA)
      {
        
      }
   }

   //int main()
   //{
   //   setlocale(LC_ALL, "Russian");

   //   int n = razmerrowvect();
   //   int m = razmercolumnvect();
   //   bool fl = false;

   //   double** a = new double*[n];

   //   FILE* fp_a = fopen("a.txt", "r");
   //   if (fp_a == nullptr)
   //   {
   //      printf("Ошибка при открытии файла для чтенияn");
   //      return 1;
   //   }

   //   vvod_vect(a, n, m, fp_a);
   //   fclose(fp_a);

   //   double* b;
   //   find_max(b, a, n, m, fl);

   //   FILE* fp_finish = fopen("finish.txt", "w");
   //   if (fp_finish == nullptr)
   //   {
   //      printf("Ошибка при открытии файла для записиn");
   //      delete[] b;
   //      return 1;
   //   }

   //   vivod_vector(b, n, fp_finish);
   //   fclose(fp_finish);
   //}

   //void vvod_vect(double**& x, int n, int m, FILE* f)
   //{
   //}

   //void find_max(double*& y, double** a, int n, int m, bool fl)
   //{
   //}

   //void vivod_vector(double* x, int n, FILE* f)
   //{
   //}
}
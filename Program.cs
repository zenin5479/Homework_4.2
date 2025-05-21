using System;
using System.Collections.Generic;
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
         string filePath = AppContext.BaseDirectory + "a.txt";
         // Двумерный массив вещественных чисел
         double[,] arrayDouble = { };
         // Чтение файла за одну операцию
         string[] allLines = File.ReadAllLines(filePath);
         if (allLines == null)
         {
            Console.WriteLine("Ошибка при открытии файла для чтения");
         }
         else
         {
            Console.WriteLine("Исходный массив строк");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            int indexLines = 0;
            while (indexLines < allLines.Length)
            {
               allLines[indexLines] = allLines[indexLines];
               Console.WriteLine(allLines[indexLines]);
               indexLines++;
            }

            // Разделение строки на подстроки по пробелу для определения количества столбцов в строке
            int[] sizeArray = new int[allLines.Length];
            char symbolSpace = ' ';
            int countRow = 0;
            int countSymbol = 0;
            int countСolumn = 0;
            while (countRow < allLines.Length)
            {
               string line = allLines[countRow];
               while (countSymbol < line.Length)
               {
                  if (symbolSpace == line[countSymbol])
                  {
                     countСolumn++;
                  }

                  if (countSymbol == line.Length - 1)
                  {
                     countСolumn++;
                  }

                  countSymbol++;
               }

               sizeArray[countRow] = countСolumn;
               //Console.WriteLine("В строке {0} количество столбцов {1}", countRow, countСolumn);
               countСolumn = 0;
               countRow++;
               countSymbol = 0;
            }

            Console.ResetColor();
            Console.WriteLine();

            // Разделение строки на подстроки по пробелу и конвертация подстрок в double
            Console.WriteLine("Двухмерный числовой массив"); //
            StringBuilder stringModified = new StringBuilder();
            arrayDouble = new double[allLines.Length, sizeArray.Length];
            char spaceCharacter = ' ';
            int row = 0;
            int column = 0;
            int countCharacter = 0;
            while (row < arrayDouble.GetLength(0))
            {
               string line = allLines[row];
               while (column < sizeArray[row])
               {
                  while (countCharacter < line.Length)
                  {
                     if (spaceCharacter != line[countCharacter])
                     {
                        stringModified.Append(line[countCharacter]);
                     }
                     else
                     {
                        string subLine = stringModified.ToString();
                        arrayDouble[row, column] = Convert.ToDouble(subLine);
                        Console.Write(arrayDouble[row, column] + " ");
                        stringModified.Clear();
                        column++;
                     }

                     if (countCharacter == line.Length - 1)
                     {
                        string subLine = stringModified.ToString();
                        arrayDouble[row, column] = Convert.ToDouble(subLine);
                        Console.Write(arrayDouble[row, column]);
                        stringModified.Clear();
                        column++;
                     }

                     countCharacter++;
                  }

                  countCharacter = 0;
               }

               Console.WriteLine();
               column = 0;
               row++;
            }
            Console.ResetColor();
         }

         Console.WriteLine();
         Console.WriteLine("Двумерный числовой массив для проведения поиска");
         double[,] arraySearch = TwoDimensionalArray.InputArray(arrayDouble, n, m);
         Console.WriteLine();

         // Поиск максимального элемента строки (без флагов bool)
         double[] arrayMax = new double[arraySearch.GetLength(0)];
         int rowOut = 0;
         int columnOut = 0;
         while (rowOut < arraySearch.GetLength(0))
         {
            // Cчитаем, что максимум - это первый элемент строки
            double maxOut = arraySearch[rowOut, 0];
            while (columnOut < arraySearch.GetLength(1))
            {
               if (maxOut < arraySearch[rowOut, columnOut])
               {
                  maxOut = arraySearch[rowOut, columnOut];
               }

               columnOut++;
            }

            arrayMax[rowOut] = maxOut;
            //Console.WriteLine("Максимум в строке {0} равен: {1}", rowOut, maxOut);
            columnOut = 0;
            rowOut++;
         }

         Console.WriteLine("Массив максимальных значений строк");
         int indexMax = 0;
         while (indexMax < arrayMax.Length)
         {
            Console.Write("{0} ", arrayMax[indexMax]);
            indexMax++;
         }

         Console.WriteLine();

         TwoDimensionalArray.FileWriteArray(arrayMax);
         TwoDimensionalArray.FileWriteString(arrayMax);

         Console.ReadKey();
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
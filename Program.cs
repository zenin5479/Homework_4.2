using System;
using System.IO;

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
      static void Main(string[] args)
      {
         // Переводит (,) в (.)
         //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

         // LibraryForTwoDimensionalArray

         int n = Razmerrow();
         int m = Razmercolumn();
         bool fl = false;

         double[,] a = new double[n, m];
         
         string filePath = AppContext.BaseDirectory;
         Console.WriteLine(filePath);

         FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read);

         FILE* fp_a = fopen("a.txt", "r");
         if (fp_a == nullptr)
         {
            printf("Ошибка при открытии файла для чтенияn");
            return 1;
         }

         Console.ReadKey();
      }

      private static int Razmerrow()
      {
         int n;
         do
         {
            Console.WriteLine("Введите количество строк массива А");
            int.TryParse(Console.ReadLine(), out n);
            //n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0 || n >= 20)
            {
               Console.WriteLine("Введено не верное значение");
            }
         } while (n <= 0 || n >= 20);

         return n;
      }

      private static int Razmercolumn()
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

   //   for (int i = 0; i < n; i++)
   //   {
   //      delete[] a[i];
   //   }
   //   delete[] a;
   //   delete[] b;

   //   return 0;
   //}


   //int razmerrowvect()
   //{
   //   int n;
   //   do
   //   {
   //      printf("%s", "Введите количество строк массива А\n");
   //      scanf("%d", &n);
   //      if (n <= 0 || n >= 20)
   //      {
   //         printf("%s", "Введено не верное значение\n");
   //      }
   //   } while (n <= 0 || n >= 20);

   //   return n;
   //}

   //int razmercolumnvect()
   //{
   //   int m;
   //   do
   //   {
   //      printf("%s", "Введите количество столбцов массива А\n");
   //      scanf("%d", &m);
   //      if (m <= 0 || m >= 20)
   //      {
   //         printf("%s", "Введено не верное значение\n");
   //      }
   //   } while (m <= 0 || m >= 20);
   //   return m;
   //}

   //void vvod_vect(double**& x, int n, int m, FILE* f)
   //{
   //   for (int i = 0; i < n; i++)
   //   {
   //      x[i] = new double[m];
   //      for (int j = 0; j < m; j++)
   //      {
   //         fscanf(f, "%lf", &x[i][j]);
   //         printf("%lf ", x[i][j]);
   //      }
   //      printf("%s", "\n");
   //   }
   //}

   //void find_max(double*& y, double** a, int n, int m, bool fl)
   //{
   //   fl = false;
   //   y = new double[n];
   //   for (int i = 0; i < n; i++)
   //   {
   //      double max = a[i][0];
   //      for (int j = 1; j < m; j++)
   //      {
   //         if (a[i][j] > max)
   //         {
   //            max = a[i][j];
   //            fl = true;
   //         }
   //      }
   //      if (fl == true)
   //      {
   //         y[i] = max;
   //      }
   //   }
   //}

   //void vivod_vector(double* x, int n, FILE* f)
   //{
   //   for (int i = 0; i < n; i++)
   //   {
   //      fprintf(f, "%lf ", x[i]);
   //   }
   //   printf("%s", "\n");
   //}
}

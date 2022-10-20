namespace Unit13_3;

class Program
   {
       static void Main(string[] args)
       {
           int [,] myArray =
           {
               { 5, 8, 3, 10 },
               { 13, 2, 1, 7 },
               { 0, 2, 5, 2 },
               { 3, 8, 3, 45 },
               { 2, 4, 31, 4 }
           };
          
           // Двумерный массив можно представить в виде таблицы.
 
           //  сохраним длину первого измерения массива (ширина таблицы)
           int rowLength = myArray.GetLength(0);
          
           //  сохраним длину второго измерения массива (высота таблицы)
           int columnLength = myArray.GetLength(1);
 
           // проход по рядам
           for (int i = 0; i < rowLength; i++)
           {
               // проход по колонкам
               for (int j = 0; j < columnLength; j++)
                   Console.WriteLine(myArray[i, j]);
           }
       }
   }
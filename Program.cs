using System.Collections;
using System.Text;

namespace ArrayListExample
{
   class Program
   {
       static void Main(string[] args)
       {
           // Объявим ArrayList с элементами разных типов
           var arrayList = new ArrayList()
           {
               1,
               "Андрей ",
               "Сергей ",
               300,
           };
          
           // переменная для хранения суммы
           int sum = 0;
          
           // переменная для хранения текста.
           // Можно было бы использовать String, но в случае когда необходимо выполнять много
           // операций с одной строкой - лучше использовать класс StringBuilder
           StringBuilder text = new StringBuilder();
          
           // проходим список и проверяем элементы на соответствие типу
           foreach (var element in arrayList)
           {
               //   если целое число - увеличиваем счётчик
               if (element is int)
               {
                   sum += (int)element;
               }
 
               // если строка - добавляем текст из неё
               if (element is string s)
               {
                   text.Append(element);
               }
           }
          
           // результат
           var result = new ArrayList() { sum, text.ToString() } ;
 
           // вывод
           foreach (var elem in result)
           {
               Console.WriteLine(elem);
           }
       }
   }
}
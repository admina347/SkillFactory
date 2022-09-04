using System;
/* Задание 7.2.14
Для следующего класса напишите индексатор, для типа параметра используйте int:*/
class Program
{
    class IndexingClass
    {
        private int[] array;
        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        // Индексатор по массиву
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }
    static void Main(string[] args)
    {

    }
}
/*
Понятно что для задания нужно использовать событие.
Но не понятно зачем все это городить - можно было сразу использовать switch case и реализовать проще.
Вобщем пока не понятно где и для чего применять делегаты Ковариантность и контравариантность делегатов и события.
С событиями еще более менее есть идеи где применить.
*/
namespace EventPrictices //9.6.1 (HW-03)
{
    class NumberReader
    {
        public delegate void NumberInputDelegate(Human[] humans, int number);
        public event NumberInputDelegate NumberInputEvent;
        public void Read(Human[] humans)
        {
            Console.WriteLine();
            Humans.ShowAll(humans);
            Console.WriteLine("Для сортировки А-Я введите 1");
            Console.WriteLine("Для сортировки Я-А введите 2");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new IndexOutOfRangeException();
            NumberInput(humans, number);
        }
        protected virtual void NumberInput(Human[] humans, int number)
        {
            NumberInputEvent?.Invoke(humans, number);
        }
    }
}
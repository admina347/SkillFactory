/*
Понятно что для задания нужно использовать событие.
Но не понятно зачем все это городить - можно было сразу использовать switch case и реализовать проще.
Вобщем пока не понятно где и для чего применять делегаты Ковариантность и контравариантность делегатов и события.
С событиями еще более менее есть идеи где применить.
*/
namespace EventPrictices //9.6.1 (HW-03)
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            IHumans rHumans;
            rHumans = new Humans();
            Human[] humans = rHumans.GetAll();
            
            //
            NumberReader numberReader = new NumberReader();
            numberReader.NumberInputEvent += SortHuman;
            try
            {
                numberReader.Read(humans);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено не корректное значение");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Введеное значение находится за пределами границ массива или коллекции.");
            }
        }

        static void SortHuman(Human[] humans, int number)
        {
            Console.WriteLine();
            switch (number)
            {
                case 1:
                    {
                        Array.Sort(humans, (x, y) => String.Compare(x.LastName, y.LastName));     //Сортировка
                        Console.WriteLine("Сортировка А-Я");
                        Humans.ShowAll(humans);
                        break;
                    }
                case 2:
                    {
                        Array.Sort(humans, (x, y) => String.Compare(y.LastName, x.LastName));     //Сортировка
                        Console.WriteLine("Сортировка Я-А");
                        Humans.ShowAll(humans);
                        break;
                    }
            }
        }
    }
}
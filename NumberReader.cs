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
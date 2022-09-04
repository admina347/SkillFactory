using System;
/* Задание 7.2.12
Для класса Obj перегрузите операторы + и -, чтобы результатом работы 
оператора был новый экземпляр класса Obj, а операции производились над полем Value. */
class Program
{
    class Obj
    {
        public int Value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }
    static void Main(string[] args)
    {

    }
}
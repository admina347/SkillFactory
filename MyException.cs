/* 
Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек.
Сортировка должна происходить при помощи события. 
Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).
*/
namespace EventPrictices //9.6.1 (HW-03)
{
    public class MyException : Exception
    {
        public MyException() { }

        public MyException(string message) : base(message) { }

    }
}
namespace Unit10
{
    class Program
    {
        static void Main(string[] args)
        {
            IUpdater<User> serviceUser = new UserService<User>();
            serviceUser.Update(new User());

            IUpdater<Account> serviceAccount = new UserService<Account>();
            serviceAccount.Update(new Account());
        }
    }
    public class User
    {

    }

    public class Account : User
    {

    }
    class UserService<T> : IUpdater<T> where T : User
    {
        public void Update(T entity)
        {
            Console.WriteLine(entity.GetType());
        }
    }
    public interface IUpdater<in T>
    {
        void Update(T entity);
    }
}
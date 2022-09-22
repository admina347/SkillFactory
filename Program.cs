namespace CovAndContrPractices
{
    class Program
    {
        public delegate Parent HandlerMethod();
        delegate void ChildInfo(Child child);

        public static Parent ParentHandler()
        {
            return null;
        }


        public static Child ChildHandler()
        {
            return null;
        }

        static void Main(string[] args)
        {
            ChildInfo childInfo = GetParentInfo;

            childInfo.Invoke(new Child());


        }

        public static void GetParentInfo(Parent p)
        {
            Console.WriteLine(p.GetType());
        }
    }

    class Parent { }

    class Child : Parent {  }
}
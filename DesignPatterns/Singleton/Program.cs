namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private int _a = 1;
        private Singleton() { }

        private static Singleton? _instance;

        public static Singleton GetInstance()
        {
            return _instance ??= new Singleton();
        }
        
        public void SomeBusinessLogic()
        {
            Console.WriteLine(_a++);
        }
    }

    class  Program
    {
        public void Run()
        {
            var t1 = Singleton.GetInstance();
            var t2 = Singleton.GetInstance();
            t1.SomeBusinessLogic();
            t2.SomeBusinessLogic();
            Console.WriteLine(t1 == t2
                ? "both variables contain the same instance."
                : "variables contain different instances.");
        }
    }
    
}
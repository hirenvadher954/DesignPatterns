namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Singleton Pattern
            var s1 = new Singleton.Program();
            s1.Run();
            
            // Factory Method
            var s2 = new FactoryMethod.FactoryMethod();
            s2.Run();
            
        }
    }
}


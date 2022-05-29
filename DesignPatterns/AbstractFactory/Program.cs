using System.Runtime.InteropServices;
using DesignPatterns.AbstractFactory.app;
using DesignPatterns.AbstractFactory.factories;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        private static Application ConfigureApplication()
        {
            Application app;
            IGUIFactory factory;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                factory = new WindowsFactory();
                app = new Application(factory);
            }
            else
            {
                factory = new MacOSFactory();
                app = new Application(factory);
            }
            return app;
        }

        public static void Run(string[] args)
        {
            var app = ConfigureApplication();
            app.Paint();
        }
    }
}
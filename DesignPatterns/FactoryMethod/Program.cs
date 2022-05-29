using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DesignPatterns.FactoryMethod
{
    public interface IButton
    {
        void Render();
        void OnClick();
    }

    class HtmlButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("<button>Test Button</button>");
            OnClick();
        }

        public void OnClick()
        {
            Console.WriteLine("Click! Button says - 'HTMLButton'");
        }
    }

    class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows Button Code");
        }

        public void OnClick()
        {
            Console.WriteLine("Click! Button says - 'WindowsButton'");
        }
    }

    abstract class Dialog
    {
        public void RenderWindow()
        {
            var okButton = CreateButton();
            okButton.Render();
        }

        protected abstract IButton CreateButton();
    }

    class HtmlDialog : Dialog
    {
        protected override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }

    class WindowsDialog : Dialog
    {
        protected override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }

    public class FactoryMethod
    {
        private static Dialog? _dialog;

        public void Run()
        {
            Configure();
            RunBusinessLogic();
        }

        private static void Configure()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                _dialog = new WindowsDialog();
            }
            else
            {
                _dialog = new HtmlDialog();
            }
        }

        private static void RunBusinessLogic()
        {
            _dialog?.RenderWindow();
        }
    }
}
using DevGuru.Patterns.FactoryMethod.Interfaces;
using System;

namespace DevGuru.Patterns.FactoryMethod.Dialogs
{
    public abstract class Dialog
    {
        public void Render()
        {
            var button = CreateButton();
            button.OnClick(() => Console.WriteLine("Callback function after click is executed."));
            button.Render();
        }

        protected abstract IOkButton CreateButton();
    }
}

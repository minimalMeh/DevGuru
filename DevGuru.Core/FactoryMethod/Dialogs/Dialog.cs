using System;
using DevGuru.Core.FactoryMethod.Interfaces;

namespace DevGuru.Core.FactoryMethod.Dialogs
{
    public abstract class Dialog
    {
        public void Render()
        {
            var button = CreateButton();
            button.OnClick(() => Console.WriteLine("It's ok bro to be sad."));
            button.Render();
        }

        protected abstract IOkButton CreateButton();
    }
}

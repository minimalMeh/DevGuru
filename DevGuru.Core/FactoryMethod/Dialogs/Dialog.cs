using DevGuru.Core.FactoryMethod.Interfaces;
using System;

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

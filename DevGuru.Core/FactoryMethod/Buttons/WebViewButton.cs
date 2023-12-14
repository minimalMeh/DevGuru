using DevGuru.Core.FactoryMethod.Interfaces;
using System;

namespace DevGuru.Core.FactoryMethod.Buttons
{
    public class WebViewButton : IOkButton
    {
        public void OnClick(Action callback)
        {
            Console.WriteLine("WebView button clicked.");
            callback();
        }

        public void Render()
        {
            Console.WriteLine("WebView button rendered.");
        }
    }
}

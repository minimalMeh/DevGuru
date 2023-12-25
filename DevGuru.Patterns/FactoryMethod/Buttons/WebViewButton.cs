using DevGuru.Patterns.FactoryMethod.Interfaces;
using System;

namespace DevGuru.Patterns.FactoryMethod.Buttons
{
    public class WebViewButton : IOkButton
    {
        public void OnClick(Action callback)
        {
            Console.WriteLine("WebView button is clicked.");
            callback();
        }

        public void Render()
        {
            Console.WriteLine("WebView button is rendered.");
        }
    }
}

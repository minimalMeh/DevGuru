﻿using System;
using DevGuru.Core.AbstractFactory.Interfaces;

namespace DevGuru.Core.AbstractFactory.Mac
{
    public class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine($"{nameof(MacButton)} clicked");
        }

        public void Draw()
        {
            Console.WriteLine($"{nameof(MacButton)} is drawn");
        }
    }
}

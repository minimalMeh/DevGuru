using System;

namespace DevGuru.Patterns.FactoryMethod.Interfaces
{
    public interface IOkButton
    {
        void Render();
        void OnClick(Action callback);
    }
}

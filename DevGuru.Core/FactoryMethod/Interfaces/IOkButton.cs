using System;

namespace DevGuru.Core.FactoryMethod.Interfaces
{
    public interface IOkButton
    {
        void Render();
        void OnClick(Action callback);
    }
}

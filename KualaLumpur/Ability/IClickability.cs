using System;

namespace KualaLumpur.Ability
{
    public interface IClickability
    {
        void Click();
        void DoubleClick();
        void Register(Action beforeClick, Action afterClick);
    }
}

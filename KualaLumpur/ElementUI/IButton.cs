using KualaLumpur.Ability;
using System;

namespace KualaLumpur.ElementUI
{

    public interface IButton : IReadAbility, IExistability
    {
        void Click();
        void DoubleClick();
        IButton WithClickActions(Action beforeClick, Action afterClick);
        IButton WithHeight(int height);
    }
}

using System;

namespace KualaLumpur.Ability
{
    public class CustomClickability : IClickability
    {
        private Action _beforeClick;
        private Action _afterClick;
        public void Click()
        {
            _beforeClick?.Invoke();
            Console.WriteLine("Custom Click!!!");
            _afterClick?.Invoke();
        }

        public void DoubleClick()
        {
            _beforeClick?.Invoke();
            Console.WriteLine("Custom DoubleClick!!!");
            _afterClick?.Invoke();
        }

        public void Register(Action beforeClick, Action afterClick)
        {
            _beforeClick = beforeClick;
            _afterClick = afterClick;
        }
    }
}

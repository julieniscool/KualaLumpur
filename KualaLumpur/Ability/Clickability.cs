using System;

namespace KualaLumpur.Ability
{
    public class Clickability : IClickability
    {
        private Action _beforeClick;
        private Action _afterClick;

        public void Click()
        {
            _beforeClick?.Invoke();
            Console.WriteLine("Click!");
           
            _afterClick?.Invoke();
            throw new NotImplementedException("Juju4Ever");
        }

        public void DoubleClick()
        {
            _beforeClick?.Invoke();
            Console.WriteLine("DoubleClick!");
            _afterClick?.Invoke();
        }

        public void Register(Action beforeClick, Action afterClick)
        {
            _beforeClick = beforeClick;
            _afterClick = afterClick;
        }
    }
}

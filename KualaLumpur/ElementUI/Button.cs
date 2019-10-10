using KualaLumpur.Ability;
using System;

namespace KualaLumpur.ElementUI
{
    public class Button : IButton
    {
        private readonly IReadAbility _readAbility;
        private readonly IExistability _existability;
        private readonly IClickability _clickability;
        private int _height = 10;
        private string _selecteur;

        public Button(string selecteur, IReadAbility readAbility, IExistability existability, IClickability clickability)
        {
            _selecteur = selecteur;
            _readAbility = readAbility;
           _existability = existability;
           _clickability = clickability;
            Console.WriteLine($"Selecteur {_selecteur}");
        }

        public void Click()
        {
            _clickability.Click();
        }

        public void DoubleClick()
        {
            _clickability.DoubleClick();
        }

        public bool CanRead()
        {
            return _readAbility.CanRead();
        }

        public bool Exists()
        {
            return _existability.Exists();
        }

        public IButton WithClickActions(Action beforeClick, Action afterClick)
        {
            _clickability.Register(beforeClick, afterClick);
            return this;
        }

        public IButton WithHeight(int height)
        {
            _height = height;
            return this;
        }
    }
}

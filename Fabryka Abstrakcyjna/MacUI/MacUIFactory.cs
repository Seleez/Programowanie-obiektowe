using Fabryka_Abstrakcyjna.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna.WindowsUI
{
    internal class MacUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }
        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}

using Fabryka_Abstrakcyjna.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna.WindowsUI
{
    internal class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}

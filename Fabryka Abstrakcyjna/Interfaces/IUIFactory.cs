using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna.Interfaces
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}

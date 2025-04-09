using Fabryka_Abstrakcyjna.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna
{
    public class ApplicationUI
    {
        private IUIFactory factory;

        public ApplicationUI(IUIFactory factory)
        {
            this.factory = factory;
        }

        public void CreateUI()
        {
            var button = factory.CreateButton();
            var textBox = factory.CreateTextBox();

            button.Render();
            textBox.Render();
        }
    }
}

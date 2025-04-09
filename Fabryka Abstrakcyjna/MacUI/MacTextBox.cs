using Fabryka_Abstrakcyjna.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna.WindowsUI
{
    internal class MacTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Renderuje Mac Text Box");
        }
    }
}

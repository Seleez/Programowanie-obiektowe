using Fabryka_Abstrakcyjna.WindowsUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationUI app = new ApplicationUI(new WebUIFactory());
            app.CreateUI();
        }
    }
}

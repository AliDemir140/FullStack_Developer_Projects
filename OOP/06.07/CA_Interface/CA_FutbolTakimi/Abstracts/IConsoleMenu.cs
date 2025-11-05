using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakimi.Abstracts
{
    internal interface IConsoleMenu
    {
        string CreateSampleFutbolcular();
        string GetConsoleMenu();
        void GetFutbolcular(string selectedMenu);
    }
}

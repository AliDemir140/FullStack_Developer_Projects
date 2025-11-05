using SOLID_Project.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.Abstracts
{
    public interface IMevkii
    {
        //bu class bünyesinde barındırdığı bir eylem (metot) ile geriye bir futbolcu döndürecek.

        Futbolcu Olustur(IFutbolcu futbolcu);
    }
}

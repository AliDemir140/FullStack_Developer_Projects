using OCP_Example.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example.Abstracts
{
    public interface IDepartment
    {
        Employee Create(IEmployee employee);
    }
}

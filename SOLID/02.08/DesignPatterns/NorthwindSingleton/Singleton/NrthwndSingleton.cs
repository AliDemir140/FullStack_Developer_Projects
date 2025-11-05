using NorthwindSingleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindSingleton.Singleton
{
    public class NrthwndSingleton
    {
        private NorthwindContext _context; //null

        public NorthwindContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new NorthwindContext();
                }
                return _context;
            }

        }
    }
}

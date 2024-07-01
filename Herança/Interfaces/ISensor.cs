using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Interfaces
{
    public interface ISensor
    {
        double ReadValue();
        string GetUnit();
    }
}

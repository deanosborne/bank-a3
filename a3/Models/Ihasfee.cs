using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.Models
{
    interface Ihasfee
    {
        decimal Fee();
    }

    interface Ihasinterest
    {
        decimal Interest();
    }

    interface Ihasname
    {
        string Name();
    }
}

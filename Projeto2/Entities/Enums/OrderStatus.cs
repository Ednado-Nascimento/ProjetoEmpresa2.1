using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Entities.Enums
{
    enum OrderStatus: int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivere = 3
    }
}

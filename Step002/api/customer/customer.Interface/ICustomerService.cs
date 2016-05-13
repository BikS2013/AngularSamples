using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer.Interface
{
    public interface ICustomerService
    {
        Customer Insert(Customer item);
        Customer[] Find(CustomerSearch query);
        Customer Update(Customer item);
    }
}

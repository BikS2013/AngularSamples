using customer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace customer.Controller
{
    public class CustomerController: ApiController 
    {
        ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        Response<T> handleExecution<T> ( Func<T> func)
        {
            try
            {
                return new Response<T> { Payload = func() };
            }
            catch(Exception ex)
            {
                return new Response<T> { Exception = ex.Message };
            }
        }

        public Response<Customer> Add( Customer item)
        {
            return handleExecution(() => _service.Insert(item) );
        }

        public Response<Customer[]> Find( CustomerSearch query)
        {
            return handleExecution(() => _service.Find(query) );
        }
    }
}

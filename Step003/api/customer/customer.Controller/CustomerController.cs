using Controllers;
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


        public Response<Customer> Add( Customer item)
        {
            return Response<Customer>.Get(() => _service.Add(item) );
        }

        public Response<Customer[]> Find( CustomerSearch query)
        {
            return Response<Customer[]>.Get(() => _service.Find(query) );
        }
    }
}

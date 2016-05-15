using Controllers;
using product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace product.Controller
{
    public class ProductController: ApiController
    {
        IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        public Response<Product> Add(Product item)
        {
            return Response<Product>.Get(() => _service.Add(item));
        }

        public Response<Product[]> Find(ProductSearch query)
        {
            return Response<Product[]>.Get(() => _service.Find(query));
        }

    }
}

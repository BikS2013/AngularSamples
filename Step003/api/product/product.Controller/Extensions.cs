using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Controller
{
    public static class Extensions
    {
        public static Implementation.Product GetImplementation(this Interface.Product product)
        {
            if (product == null) return null;
            return new Implementation.Product
            {
                Id = product.Id ?? Guid.NewGuid(),
                Name = product.Name
            };
        }
        public static Interface.Product GetInterface(this Implementation.Product product)
        {
            if (product == null) return null;
            return new Interface.Product
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}

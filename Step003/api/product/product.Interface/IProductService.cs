using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Interface
{
    public interface IProductService
    {
        Product Add(Product item);
        Product[] Find(ProductSearch query);
        Product Update(Product item);
    }
}

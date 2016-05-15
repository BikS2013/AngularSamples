using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Implementation
{
    public class Product
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }

        public int? Version { get; set; }
        public DateTime? VersionTime { get; set; }
        public string VersionUser { get; set; }

    }
}

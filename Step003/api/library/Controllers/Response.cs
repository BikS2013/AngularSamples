using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class Response<T>
    {
        public T Payload { get; set; }

        public string Exception { get; set; }

        public static Response<T> Get(Func<T> func)
        {
            try
            {
                return new Response<T> { Payload = func() };
            }
            catch (Exception ex)
            {
                return new Response<T> { Exception = ex.Message };
            }
        }

    }
}

﻿using customer.Interface;
using MemoryList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer.Implementation
{
    public class CustomerService : ICustomerService
    {

        static object customerLock = new object();
        static List<Customer> customers = new List<Customer>();


        T executeWithLock<T>(Func<T> func)
        {
            lock (customerLock)
            {
                return func();
            }
        }

        Customer[] getAll(CustomerSearch query)
        {
            if (query == null || (query.Id == null && query.Name == null))
            {
                return executeWithLock(() => customers.ToArray());
            }
            return null; 
        }
        Customer[] getById(CustomerSearch query)
        {
            if (query?.Id != null)
            {
                return executeWithLock(() => customers.Where(i => i.Id == query.Id).ToArray());
            }
            return null;
        }
        Customer[] getByName(CustomerSearch query)
        {
            if (query?.Name != null)
            {
                return executeWithLock(() => customers.Where(i => i.Name.StartsWith(query.Name)).ToArray());
            }
            return null;
        }

        public Customer[] Find(CustomerSearch query)
        {
            return getById(query) ?? getByName(query) ?? getAll(query);
        }


        bool chkIfExist(Customer item)
        {
            if (item?.Id == null) throw new Exception("invalid item ");
            return customers.Any(i => i?.Id == item?.Id);
        }

        public Customer Add(Customer item)
        {
            if (item?.Id == null) throw new Exception("Invalid customer, customer id");
            return executeWithLock(() => {
                customers.AddIfNotExistOrException(item, chkIfExist);
                return item;
            });
        }

        public Customer Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}

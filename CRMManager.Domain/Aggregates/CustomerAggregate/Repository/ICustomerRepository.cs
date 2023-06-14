using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using CRMManager.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Domain.Aggregates.CustomerAggregate.Repository
{
    public interface ICustomerRepository:IBaseRepository<Customer,CustomerId>
    {
    }
}

using CRMManager.Application.Features.Customers.Commands.Delete;
using CRMManager.Application.Features.Customers.Dtos;
using CRMManager.Application.Features.Customers.Queries.GetById;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Common.Mapping
{
    public class CustomerMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
           config.NewConfig<Customer,CustomerDto>().
                Map(dest=> dest.Id,src=> src.Id.Value);
            config.NewConfig<int, DeleteCustomerCommand>().
                MapWith(src => new DeleteCustomerCommand(src));
            config.NewConfig<int, GetCustomerByIdQuery>().
                MapWith(src => new GetCustomerByIdQuery(src));
        }
    }
}

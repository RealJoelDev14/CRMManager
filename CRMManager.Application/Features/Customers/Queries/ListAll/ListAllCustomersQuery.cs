using CRMManager.Application.Features.Customers.Dtos;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Features.Customers.Queries.ListAll
{
    public record ListAllCustomersQuery() : IRequest<List<CustomerDto>>;
}

using CRMManager.Application.Features.Customers.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Features.Customers.Queries.GetById
{
    public record GetCustomerByIdQuery
    (
     int Id
     ):IRequest<CustomerDto>;
}

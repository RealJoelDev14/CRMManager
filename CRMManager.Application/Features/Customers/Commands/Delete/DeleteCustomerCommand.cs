using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Features.Customers.Commands.Delete
{
    public record DeleteCustomerCommand
   (
        int Id
    
    ):IRequest;
}

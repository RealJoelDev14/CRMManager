using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Features.Customers.Commands.Update
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

        }
        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
           var customer= await _customerRepository.GetByIdAsync(CustomerId.Create(request.Id));
            if(customer is not null)
            {
                customer.SetName(request.Name);
                customer.SetStreet(request.Street);
                customer.SetTaxNumber(request.TaxNumber);
                await _customerRepository.UpdateAsync(customer);
            }
        }
    }
}

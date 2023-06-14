using CRMManager.Application.Features.Customers.Dtos;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Features.Customers.Queries.GetById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery,CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository,IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;

        }
        public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer= await _customerRepository.GetByIdAsync(CustomerId.Create(request.Id));
            return  _mapper.Map<CustomerDto>(customer);
        }
    }
}

using CRMManager.Application.Features.Customers.Dtos;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Features.Customers.Queries.ListAll
{
    public class ListAllCustomersQueryHandler : IRequestHandler<ListAllCustomersQuery, List<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public ListAllCustomersQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;

        }
        public async Task<List<CustomerDto>> Handle(ListAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<CustomerDto>>(await _customerRepository.GetAllAsync());
        }
    }
}

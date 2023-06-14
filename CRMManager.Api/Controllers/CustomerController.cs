using CRMManager.Application.Features.Customers.Commands.Create;
using CRMManager.Application.Features.Customers.Commands.Delete;
using CRMManager.Application.Features.Customers.Commands.Update;
using CRMManager.Application.Features.Customers.Queries;
using CRMManager.Application.Features.Customers.Queries.GetById;
using CRMManager.Application.Features.Customers.Queries.ListAll;
using CRMManager.Contracts.Requests.Customer;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CustomerController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new ListAllCustomersQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = _mapper.Map<GetCustomerByIdQuery>(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerRequest createCustomerRequest)
        {
            var command = _mapper.Map<CreateCustomerCommand>(createCustomerRequest);
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateCustomerRequest updateCustomerRequest)
        {
            var command = _mapper.Map<UpdateCustomerCommand>(updateCustomerRequest);
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = _mapper.Map<DeleteCustomerCommand>(id);
            await _mediator.Send(command);
            return Ok();
        }
    }
}

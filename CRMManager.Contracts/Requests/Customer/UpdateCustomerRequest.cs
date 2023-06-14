using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Contracts.Requests.Customer
{
    public record UpdateCustomerRequest
    (
        int Id,
        string Name,
        string TaxNumber,
        string Street
     );
}

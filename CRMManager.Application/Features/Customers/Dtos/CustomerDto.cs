using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Features.Customers.Dtos
{
    public record CustomerDto
    (
        int Id,
        string Name,
        string TaxNumber,
        string Street    
    );
}

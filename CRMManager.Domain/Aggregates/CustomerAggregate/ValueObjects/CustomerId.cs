using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects
{
    public class CustomerId
    {
        public int Value { get; private set; }
        private CustomerId(int value)
        {
            Value = value;

        }
        public static CustomerId Create(int value)
        { 
            return new CustomerId(value);   
        }
        private CustomerId()
        {

        }
    }
}

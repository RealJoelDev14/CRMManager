using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using CRMManager.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Domain.Aggregates.CustomerAggregate
{
    public class Customer:Entity<CustomerId>
    {
        public string Name { get; private set; }
        public string TaxNumber { get; private set; }
        public string Street { get; private set; }
        private Customer(string name,string taxNumber,string street)
        {
            Name = name;
            TaxNumber = taxNumber;
            Street = street;

        }
        public static Customer Create(string name, string taxNumber, string street)
        {
            return new Customer(name, taxNumber, street);
        }
        private Customer()
        {

        }
        public void SetStreet(string street)
        {
            Street = street;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetTaxNumber(string taxNumber)
        {
            TaxNumber = taxNumber;
        }
    }
}

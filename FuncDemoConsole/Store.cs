using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemoConsole
{
    public class Store
    {
        public int StoreId { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }

        public Store(int storeId, string countryCode, string name) {
            StoreId = storeId;
            CountryCode = countryCode;
            Name = name;
            Customers = new List<Customer>();
        }
    }
}

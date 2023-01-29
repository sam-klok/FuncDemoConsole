using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemoConsole
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}

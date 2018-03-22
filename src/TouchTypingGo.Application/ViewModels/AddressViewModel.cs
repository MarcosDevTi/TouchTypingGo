using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Application.ViewModels
{
    public class AddressViewModel
    {
        public Guid Id { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
    }
}

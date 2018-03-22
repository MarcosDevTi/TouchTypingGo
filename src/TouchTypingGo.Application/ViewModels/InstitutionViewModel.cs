using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Application.ViewModels
{
    public class InstitutionViewModel
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public AddressViewModel Address { get; private set; }
    }
}

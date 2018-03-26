namespace TouchTypingGo.Domain.Institution.Events.Address
{
    public class AddAddressEvent : AddressEvent
    {
        public AddAddressEvent(string county, string city, string street, string number, string zipCode)
        {
            County = county;
            City = city;
            Street = street;
            Number = number;
            ZipCode = zipCode;
        }
    }
}

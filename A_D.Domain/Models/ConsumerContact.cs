using System;

namespace A_D.Domain.Models
{
    public class ConsumerContact
    {
        public int Id { get; set; }
        public int Consumer_Id { get; set; }
        public int? State_Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }
        public string ZipCode { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Consumer Consumer { get; set; }
        public State State { get; set; }
    }
}

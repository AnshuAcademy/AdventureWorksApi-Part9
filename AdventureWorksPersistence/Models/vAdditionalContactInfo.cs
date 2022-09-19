using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Displays the contact name and content from each element in the xml column AdditionalContactInfo for that person.
    /// </summary>
    public partial class vAdditionalContactInfo
    {
        public int BusinessEntityID { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? TelephoneNumber { get; set; }
        public string? TelephoneSpecialInstructions { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? StateProvince { get; set; }
        public string? PostalCode { get; set; }
        public string? CountryRegion { get; set; }
        public string? HomeAddressSpecialInstructions { get; set; }
        public string? EMailAddress { get; set; }
        public string? EMailSpecialInstructions { get; set; }
        public string? EMailTelephoneNumber { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

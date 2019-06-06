using System;
using System.Collections.Generic;

namespace workshop5.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustProv { get; set; }
        public string CustPostal { get; set; }
        public string CustCountry { get; set; }
        public string CustHomePhone { get; set; }
        public string CustBusPhone { get; set; }
        public string CustEmail { get; set; }
        public int? AgentId { get; set; }
        public string PasswordNotHashed { get; set; }
        public byte[] PasswordHashed { get; set; }
        public Guid? PasswordSalt { get; set; }
    }
}

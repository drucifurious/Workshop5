using System;
using System.Collections.Generic;

namespace workshop5.Models
{
    public partial class CreditCards
    {
        public int CreditCardId { get; set; }
        public string Ccname { get; set; }
        public string Ccnumber { get; set; }
        public DateTime Ccexpiry { get; set; }
        public int CustomerId { get; set; }
    }
}

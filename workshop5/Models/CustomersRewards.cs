using System;
using System.Collections.Generic;

namespace workshop5.Models
{
    public partial class CustomersRewards
    {
        public int CustomerId { get; set; }
        public int RewardId { get; set; }
        public string RwdNumber { get; set; }
    }
}

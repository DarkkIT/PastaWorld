﻿namespace PastaWorld.Data.Models
{
    using System.Collections.Generic;
    using PastaWorld.Common;
    using PastaWorld.Data.Common.Models;

    public class Order : BaseModel<int>
    {
        public Order()
        {
            this.Items = new HashSet<CartItem>();
        }

        public ICollection<CartItem> Items { get; set; }

        public string City { get; set; } = GlobalConstants.DeliveryCity;

        public string Address { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal MealsPrice { get; set; }

        public string Status { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string FamilyName { get; set; }

        public string Email { get; set; }

        public string ClientId { get; set; }

        public ApplicationUser Client { get; set; }

        public string DistributorId { get; set; }

        public ApplicationUser Distributor { get; set; }
    }
}

﻿using System.Text.Json.Serialization;

namespace velocitaApi.models
{
    public class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string BankNumber { get; set; }

        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }
    }
}

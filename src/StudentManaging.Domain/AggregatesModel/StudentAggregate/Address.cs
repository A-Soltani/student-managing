﻿using System;

namespace StudentManaging.Domain.AggregatesModel.StudentAggregate
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        private Address(string street, string city, string state, string country, string zipcode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipcode;
        }

        public static Address AddAddress(string street, string city, string state, string country, string zipcode) =>
            new Address(street, city, state, country, zipcode);
    }
}
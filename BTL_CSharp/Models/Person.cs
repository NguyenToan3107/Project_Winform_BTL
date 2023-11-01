﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person : IComparable<Person>
    {
        public string PersonId { get; set; }
        public Fullname FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {

        }
        public Person(string id)
        {
            PersonId = id;
        }

        public Person(string personId, string fullName, DateTime birthDate, string address, string phoneNumber) : this(personId)
        {
            FullName = new Fullname(fullName);
            BirthDate = birthDate;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   PersonId == person.PersonId;
        }

        public override int GetHashCode()
        {
            return -1255590651 + EqualityComparer<string>.Default.GetHashCode(PersonId);
        }

        public int CompareTo(Person other)
        {
            return PersonId.CompareTo(other.PersonId);
        }
    }
}

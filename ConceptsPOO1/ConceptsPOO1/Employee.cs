using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace ConceptsPOO1
{
    public abstract class Employee : Ipay
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{id}, {FirstName} {LastName}," +
                $" Birth: {BirthDate}," +
                $" Hiring: {HiringDate}, " +
                $"Is Active: {IsActive}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Person() {}
        public Person(int id, string address, DateOnly dateOfBirth)
        {
            Id = id;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
        public virtual string PrintDetails() 
        {
            return $"Id: {Id}\n" +
                $"Address: {Address}\n" +
                $"Date of Birth: {DateOfBirth}";
        }
    }
}

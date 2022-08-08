using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NlogJson.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return $"{Name}  {LastName}";
        }
    }
}

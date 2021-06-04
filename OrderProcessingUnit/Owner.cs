using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class Owner
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _email;

        public Owner(string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }

        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string Email => _email;
        
    }
}

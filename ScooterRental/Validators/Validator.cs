using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Validators
{
    public class Validator
    {
        public static bool ValidateScooterId(string id) 
        {
            if (string.IsNullOrEmpty(id))
                throw new ScooterIdNullException();
            //if (_scooters.ContainsKey(scooterId))
            //    throw new ScooterNotExistsException();
            return true;
        }
    }
}

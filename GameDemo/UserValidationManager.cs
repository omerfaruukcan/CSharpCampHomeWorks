using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth == 1998 && gamer.FirstName == "Omer Faruk")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

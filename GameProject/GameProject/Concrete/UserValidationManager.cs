using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationManager
    {
        
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==123 && gamer.FirstName=="Cengizhan" && gamer.LastName=="Anar" && gamer.TcNo==1234 && gamer.DateOfBirth == 1990)
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

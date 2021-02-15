using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class GamerManager : IGamerManager
    {
        IUserValidationManager _userValidationManager;
        //Kullanıcıyı otomatik doğrulamak için constructor yapı oluşturuyoruz
        public GamerManager(IUserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer)==true)
            {
                Console.WriteLine("User added");
            }
            else
            {
                Console.WriteLine("User not added");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("User deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("UserInfo updated.");
        }

    }
}

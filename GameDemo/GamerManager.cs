using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void SignUp(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayit olundu");
            }
            else
            {
                Console.WriteLine("Dogrulama Basarisiz. Kayit Basarisiz");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit guncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit silindi");
        }
    }
}

// Bir manager sinifinin icinde baska bir manager sinifi kullanilacaksa onu newleme !

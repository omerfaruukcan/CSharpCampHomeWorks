using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.SignUp(new Gamer { Id = 1, FirstName = "Omer Faruk", DateOfBirth = 1998 });

            GamerManager gamerManager1 = new GamerManager(new NewStateUserValidationManager());
            gamerManager1.SignUp(new Gamer { FirstName = "Busra" });
        }
    }
}

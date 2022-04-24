using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IGamerService
    {
        void SignUp(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}

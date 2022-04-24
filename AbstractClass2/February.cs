using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass2
{
    class February : Month
    {
        public override int KacGundenOlusur()
        {
            return 28;
        }
        public override int YilinKacinciAyidir()
        {
            return 2;
        }
    }
}

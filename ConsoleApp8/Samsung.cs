using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Samsung : IMobilePhone
    {
        public Samsung()
        {
        }

        public INormalPhone getNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone getSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}

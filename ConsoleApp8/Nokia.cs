using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Nokia : IMobilePhone
    {
        public Nokia()
        {
        }

        public INormalPhone getNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone getSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}

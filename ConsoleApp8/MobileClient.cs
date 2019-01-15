using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public MobileClient(IMobilePhone factory)
        {
            smartPhone = factory.getSmartPhone();
            normalPhone = factory.getNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return smartPhone.getModelDetails();
        }

        public string GetNormalPhoneModelDetails()
        {
            return normalPhone.getModelDetails();
        }
    }
}

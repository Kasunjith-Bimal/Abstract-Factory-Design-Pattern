﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public interface IMobilePhone
    {
        INormalPhone getNormalPhone();


        ISmartPhone getSmartPhone();
    }
}

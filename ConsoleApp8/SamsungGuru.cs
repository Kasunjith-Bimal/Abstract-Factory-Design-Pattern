using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class SamsungGuru : INormalPhone
    {
        public string getModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}

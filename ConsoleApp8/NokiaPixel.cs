using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class NokiaPixel : ISmartPhone
    {
        public string getModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}

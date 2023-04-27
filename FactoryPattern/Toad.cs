using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Toad
    {
    }
}

namespace FactoryPatternFrogs
{
    public class Toad : _IFrogs
    {
        public Toad()
        {
        }

        public void CallSound()
        {
            Console.WriteLine("Toads aren't frogs, but they go brraaaap!, brraaaap!");
        }
    }
}
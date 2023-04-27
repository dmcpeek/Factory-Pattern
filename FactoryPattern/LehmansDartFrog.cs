using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternFrogs
{
    public class LehmansDartFrog : _IFrogs
    {
        public LehmansDartFrog()
        {
        }

        public void CallSound()
        {
            Console.WriteLine("Lehman's Dart Frog goes Peep, peep!");
        }
    }
}

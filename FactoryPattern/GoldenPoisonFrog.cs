using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternFrogs
{
    public class GoldenPoisonFrog : _IFrogs
    {
        public GoldenPoisonFrog()
        {
        }

        public void CallSound()
        {
            Console.WriteLine("The Golden Poison Frog goes Cha ching, cha ching");
        }
    }
}

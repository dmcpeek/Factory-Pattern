using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternFrogs
{
    public class AzureDartFrog : _IFrogs
    {
        public AzureDartFrog()
        {
        }

        public void CallSound()
        {
            Console.WriteLine("The Azure Dart Frog goes ribbit, ribbit!");
        }
    }
}

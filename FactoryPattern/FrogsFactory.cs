using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternFrogs
{
 
    public static class FrogsFactory
    {
        public static _IFrogs GetFrogs(string bodyColor) 
        {
            switch (bodyColor.ToLower()) 
            {
                case "red": 
                    return new LehmansDartFrog();
                case "blue":
                    return new AzureDartFrog();
                case "yellow":
                    return new GoldenPoisonFrog();
                default:
                    return new Toad();
            }
        }


    }
}

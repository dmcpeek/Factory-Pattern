using FactoryPattern;
using FactoryPatternFrogs;
using System.Runtime.InteropServices;

namespace FactoryPatternFrogs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What frog color is your favorite? (Blue, Red, Yellow, or ???)");
            string color = Console.ReadLine();

            _IFrogs instance = FrogsFactory.GetFrogs(color);
            instance.CallSound();
        }
        
    }
}

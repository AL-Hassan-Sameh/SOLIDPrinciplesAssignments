using MMBakker.SolidDesignPrinciples.LiskovSubstitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mySocket = new Socket { PowerIsOn = true };
            ILightSource myCFL = new CFL() { Socket = mySocket };
            ILightSource myIncandecent = new Incandescent() { Socket = mySocket };
            ILightSource myLED = new LED() { Socket = mySocket };
            ILightSource[] lightSources = new ILightSource[] { myCFL, myIncandecent, myLED };
            foreach (var item in lightSources)
            {
                Console.WriteLine("light source name:");
                item.PrintName();
                Console.WriteLine();
                Console.WriteLine("switching on the light source");
                item.SwitchOn();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Powering off");
                mySocket.PowerOff();
                Console.WriteLine();
                Console.WriteLine("switching on the light source");
                item.SwitchOn();
                Console.WriteLine();
                Console.WriteLine("switching on the light source again");
                item.SwitchOn();
                Console.WriteLine();
                Console.WriteLine("switching off the light source");
                item.SwitchOff();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Powering on again");
                mySocket.PowerOn();
                Console.WriteLine();
                Console.WriteLine("switching on the light source");
                item.SwitchOn();
                Console.WriteLine();
                Console.WriteLine("switching on the light source again");
                item.SwitchOn();
                Console.WriteLine();
                Console.WriteLine("switching off the light source");
                item.SwitchOff();
                Console.WriteLine("switching off the light source again");
                item.SwitchOff();
                Console.WriteLine("-------------------------------------------");
            }

        }
    }
}

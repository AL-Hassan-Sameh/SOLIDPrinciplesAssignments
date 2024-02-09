using MMBakker.SolidDesignPrinciples.LiskovSubstitution;
using System;

namespace LSPDemo
{
    public abstract class LightSource : ILightSource
    {
        protected string Type { get;}
        protected string DutchName { get;}
        public Socket Socket { get; set; }
        public bool IsSwitchedON { get; set; }

        public LightSource(string type, string dutchName)
        {
            Type = type;
            DutchName = dutchName;
        }
        public void PrintName()
        {
            Console.WriteLine($"I am a/an {Type} light, known as \"{DutchName}\" in Dutch.");
        }
        public void SwitchOn()
        {
            if(Socket.PowerIsOn == false)
            {
                IsSwitchedON = false;
                Console.WriteLine("the light cannot be turned on due to power outage");
                return;
            }
            if (IsSwitchedON == true)
            {
                Console.WriteLine("Light is already on.");
                return;
            }
            IsSwitchedON = true;
            Console.WriteLine($"{Type} is now on.");
        }

        public void SwitchOff()
        {
            if (Socket.PowerIsOn == false)
            {
                Console.WriteLine("Power is already Off");
                return;
            }
            if (IsSwitchedON == false)
            {
                Console.WriteLine("Light is already off.");
                return;
            }
            IsSwitchedON = false;
            Console.WriteLine($"{Type} is now off.");
        }

    }
}

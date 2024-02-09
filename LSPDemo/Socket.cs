using System;

namespace MMBakker.SolidDesignPrinciples.LiskovSubstitution
{
    public class Socket
    {
        public bool PowerIsOn { get; set; }
        public Socket()
        {
            PowerIsOn = true;
        }
        public void PowerOn()
        {
            PowerIsOn = true;
            Console.WriteLine("Power is ON");
        }

        public void PowerOff()
        {
            PowerIsOn = false;
            Console.WriteLine("Power is OFF");
        }
    }
}

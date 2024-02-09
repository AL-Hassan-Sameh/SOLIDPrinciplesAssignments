using LSPDemo;
using System;

namespace MMBakker.SolidDesignPrinciples.LiskovSubstitution
{
    public class LED : LightSource
    {
        public LED() : base("LED", "LED-lamp")
        {
        }
    }
}

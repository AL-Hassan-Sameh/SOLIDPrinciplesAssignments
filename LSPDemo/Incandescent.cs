using LSPDemo;
using System;

namespace MMBakker.SolidDesignPrinciples.LiskovSubstitution
{
    public class Incandescent : LightSource
    {
        public Incandescent() : base("incandescent", "gloeilamp")
        {
        }
    }
}

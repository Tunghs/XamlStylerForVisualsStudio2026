using System;

namespace Xavalon.XamlStyler.Extension.Windows
{
    internal static class Guids
    {
        public const string GuidXamlStylerPackageString = "22e4aa65-b494-46d6-9d96-852692fbbd03";
        public const string GuidXamlStylerMenuSetString = "7a406667-a27e-4495-a2ef-6f9cdcceec0c";
        public const string UIContextGuidString = "ac93c5fa-67a8-422a-8426-70db60b74954";
        public const string GuidVsStd97CmdIDString = "5EFC7975-14BC-11CF-9B2B-00AA00573819";

        public static readonly Guid GuidXamlStylerMenuSet = new Guid(Guids.GuidXamlStylerMenuSetString);
    };
}

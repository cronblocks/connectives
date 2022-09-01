namespace Connectives.GlobalSettings
{
    public static class Version
    {
        public const int MajorNumber = 1;
        public const int MinorNumber = 0;
        public const int PatchNumber = 0;

        public static string VersionString { get { return $"{MajorNumber}.{MinorNumber}.{PatchNumber}"; } }
    }
}

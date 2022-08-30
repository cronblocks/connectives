namespace Connectives.GlobalSettings
{
    public class Version
    {
        public const int MajorNumber = 1;
        public const int MinorNumber = 0;
        public const int PatchNumber = 0;

        public string VersionString { get { return $"{MajorNumber}.{MinorNumber}.{PatchNumber}"; } }
    }
}

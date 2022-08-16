namespace Connectives.Constants
{
    public class VersionInfo
    {
        public const int VersionMajorNumber = 1;
        public const int VersionMinorNumber = 0;
        public const int VersionPatchNumber = 0;

        public string VersionNumber { get { return $"{VersionMajorNumber}.{VersionMinorNumber}.{VersionPatchNumber}"; } }
    }
}

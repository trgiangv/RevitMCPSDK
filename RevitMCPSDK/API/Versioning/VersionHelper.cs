namespace RevitMCPSDK.API.Versioning
{
    /// <summary>
    /// Version comparison helper class
    /// </summary>
    public static class VersionHelper
    {
        /// <summary>
        /// Parses a version number string into a Version object
        /// </summary>
        public static Version ParseVersion(string versionString)
        {
            if (string.IsNullOrEmpty(versionString))
                return null;

            if (Version.TryParse(versionString, out Version version))
                return version;

            // Handle cases with only the year, e.g., "2022"
            if (int.TryParse(versionString, out int year))
                return new Version(year, 0, 0, 0);

            return null;
        }

        /// <summary>
        /// Compares two version numbers
        /// </summary>
        public static int CompareVersions(string version1, string version2)
        {
            var v1 = ParseVersion(version1);
            var v2 = ParseVersion(version2);

            if (v1 == null && v2 == null)
                return 0;

            if (v1 == null)
                return -1;

            if (v2 == null)
                return 1;

            return v1.CompareTo(v2);
        }
    }
}

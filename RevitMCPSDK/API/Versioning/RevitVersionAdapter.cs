﻿﻿﻿﻿using Autodesk.Revit.ApplicationServices;

namespace RevitMCPSDK.API.Versioning
{
    /// <summary>
    /// Revit version adapter, used to handle compatibility issues between different versions
    /// </summary>
    public class RevitVersionAdapter(Application app)
    {
        private readonly Application _app = app ?? throw new ArgumentNullException(nameof(app));

        /// <summary>
        /// Gets the current Revit version number
        /// </summary>
        public string GetRevitVersion()
        {
            // Get the major version number, e.g., "2022"
            return _app.VersionNumber;
        }

        /// <summary>
        /// Checks if the current Revit version supports the specified command
        /// </summary>
        /// <param name="supportedVersions">List of supported versions for the command</param>
        /// <returns>Whether the current version is supported</returns>
        public bool IsVersionSupported(System.Collections.Generic.IEnumerable<string> supportedVersions)
        {
            if (supportedVersions == null || !supportedVersions.GetEnumerator().MoveNext())
                return true; // If no supported versions are specified, default to supporting all versions

            string currentVersion = GetRevitVersion();

            foreach (string version in supportedVersions)
            {
                if (currentVersion == version)
                    return true;
            }

            return false;
        }
    }
}

﻿using Autodesk.Revit.UI;

namespace RevitMCPSDK.API.Interfaces
{
    /// <summary>
    /// Interface that all commands that need to be initialized after the Revit UI is ready must implement
    /// </summary>
    public interface IRevitCommandInitializable
    {
        /// <summary>
        /// Initializes the command
        /// </summary>
        /// <param name="uiApplication">Revit UI application</param>
        void Initialize(UIApplication uiApplication);
    }
}

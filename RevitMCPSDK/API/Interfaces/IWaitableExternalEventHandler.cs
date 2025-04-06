using Autodesk.Revit.UI;

namespace RevitMCPSDK.API.Interfaces
{
    /// <summary>
    /// Waitable external event handler interface
    /// </summary>
    public interface IWaitableExternalEventHandler : IExternalEventHandler
    {
        /// <summary>
        /// Waits for the operation to complete
        /// </summary>
        /// <param name="timeoutMs">Timeout in milliseconds</param>
        /// <returns>Whether it completed before the timeout</returns>
        bool WaitForCompletion(int timeoutMs);
    }
}

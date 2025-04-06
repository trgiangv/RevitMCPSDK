namespace RevitMCPSDK.API.Interfaces
{
    /// <summary>
    /// Command registration interface
    /// </summary>
    public interface ICommandRegistry
    {
        /// <summary>
        /// Registers a command
        /// </summary>
        /// <param name="command">The command to register</param>
        void RegisterCommand(IRevitCommand command);
        /// <summary>
        /// Tries to get a command
        /// </summary>
        /// <param name="commandName">The name of the command</param>
        /// <param name="command">The found command</param>
        /// <returns>Whether the command was found</returns>
        bool TryGetCommand(string commandName, out IRevitCommand command);
    }
}

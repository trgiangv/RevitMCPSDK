﻿﻿using Newtonsoft.Json.Linq;

namespace RevitMCPSDK.API.Interfaces
{
    /// <summary>
    /// Interface that all Revit commands must implement
    /// </summary>
    public interface IRevitCommand
    {
        /// <summary>
        /// The unique name of the command, used to identify the command in JSON-RPC requests
        /// </summary>
        string CommandName { get; }
        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="parameters">JSON-RPC parameters</param>
        /// <param name="requestId">Request ID</param>
        /// <returns>The command execution result</returns>
        object Execute(JObject parameters, string requestId);
    }
}

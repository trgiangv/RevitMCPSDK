﻿﻿namespace RevitMCPSDK.API.Models
{
    /// <summary>
    /// Command execution result
    /// </summary>
    public class CommandResult
    {
        /// <summary>
        /// Indicates if the command was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Result data
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Error message, if any
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Creates a successful result
        /// </summary>
        public static CommandResult CreateSuccess(object data = null)
        {
            return new CommandResult
            {
                Success = true,
                Data = data,
                ErrorMessage = null
            };
        }

        /// <summary>
        /// Creates a failed result
        /// </summary>
        public static CommandResult CreateError(string errorMessage, object data = null)
        {
            return new CommandResult
            {
                Success = false,
                Data = data,
                ErrorMessage = errorMessage
            };
        }
    }
}

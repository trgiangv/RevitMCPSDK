using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RevitMCPSDK.API.Models
{
    /// <summary>
    /// Base interface for JSON-RPC 2.0 responses
    /// </summary>
    public interface IJsonRPCResponse
    {
        /// <summary>
        /// JSON-RPC version, always "2.0"
        /// </summary>
        string JsonRpc { get; }

        /// <summary>
        /// Request ID, used to associate requests and responses
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Converts the response to a JSON string
        /// </summary>
        string ToJson();
    }

    /// <summary>
    /// JSON-RPC 2.0 success response
    /// </summary>
    public class JsonRPCSuccessResponse : IJsonRPCResponse
    {
        /// <summary>
        /// JSON-RPC version
        /// </summary>
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; } = "2.0";

        /// <summary>
        /// Request ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Response result
        /// </summary>
        [JsonProperty("result")]
        public JToken Result { get; set; }

        /// <summary>
        /// Converts the response to a JSON string
        /// </summary>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// JSON-RPC 2.0 error response
    /// </summary>
    public class JsonRPCErrorResponse : IJsonRPCResponse
    {
        /// <summary>
        /// JSON-RPC version
        /// </summary>
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; } = "2.0";

        /// <summary>
        /// Request ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Error information
        /// </summary>
        [JsonProperty("error")]
        public JsonRPCError Error { get; set; }

        /// <summary>
        /// Converts the response to a JSON string
        /// </summary>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// JSON-RPC 2.0 error object
    /// </summary>
    public class JsonRPCError
    {
        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Optional error data
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public JToken Data { get; set; }
    }
}

using Autodesk.Revit.UI;
using Newtonsoft.Json.Linq;
using RevitMCPSDK.API.Interfaces;
using RevitMCPSDK.API.Models;
using RevitMCPSDK.Exceptions;

namespace RevitMCPSDK.API.Base
{
    public abstract class ExternalEventCommandBase(IWaitableExternalEventHandler handler, UIApplication uiApp)
        : IRevitCommand
    {
        protected ExternalEvent Event { get; private set; } = ExternalEvent.Create(handler);
        protected IWaitableExternalEventHandler Handler { get; private set; } = handler ?? throw new ArgumentNullException(nameof(handler));
        protected UIApplication UiApp { get; private set; } = uiApp ?? throw new ArgumentNullException(nameof(uiApp));

        public abstract string CommandName { get; }

        public abstract object Execute(JObject parameters, string requestId);

        protected bool RaiseAndWaitForCompletion(int timeoutMs = 10000)
        {
            Event.Raise();
            return Handler.WaitForCompletion(timeoutMs);
        }

        protected CommandExecutionException CreateTimeoutException(string commandName)
        {
            return new CommandExecutionException(
                $"Command {commandName} execution timed out",
                JsonRPCErrorCodes.CommandExecutionTimeout);
        }
    }
}

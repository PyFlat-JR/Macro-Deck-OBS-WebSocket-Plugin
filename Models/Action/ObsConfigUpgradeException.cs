using System;

namespace SuchByte.OBSWebSocketPlugin.Models.Action
{
    internal class ObsConfigUpgradeException : Exception
    {
        public ObsConfigUpgradeException() { }

        public ObsConfigUpgradeException(string message)
            : base(message) { }

        public ObsConfigUpgradeException(string message, Exception inner)
            : base(message, inner) { }
    }
}

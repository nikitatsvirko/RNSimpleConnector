using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Simple.Connector.RNSimpleConnector
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSimpleConnectorModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSimpleConnectorModule"/>.
        /// </summary>
        internal RNSimpleConnectorModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSimpleConnector";
            }
        }
    }
}

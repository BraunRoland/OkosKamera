using System;
using System.Collections.Generic;
using System.Text;

namespace OkosKamera
{
    internal interface INetworkConnection
    {
        public void ConnectToWifi(string ssid);
        public bool IsConnected();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OkosKamera
{
    internal class SmartCamera : INetworkConnection, IRecordable
    {
        private string connectionSsid;
        private bool connected;
        private bool turnedOn;
        private bool recording;

        public SmartCamera()
        {
            this.connectionSsid = "";
            this.connected = false;
            this.turnedOn = false;
            this.recording = false;
        }

        public SmartCamera(string connectionSsid)
        {
            this.connectionSsid = connectionSsid;
            this.connected = true;
            this.turnedOn = true;
            this.recording = false;
        }

        public string ConnectionSsid {
            get => connectionSsid; 
            set
            {
                connectionSsid = value;
                if (this.connectionSsid == "")
                {
                    this.connected = false;
                }
                else
                {
                    this.connected = true;
                }
            } 
        }
        public bool Connected { get => connected; set => connected = value; }
        public bool TurnedOn { get => turnedOn; set => turnedOn = value; }
        public bool Recording { get => recording; set => recording = value; }

        public void ConnectToWifi(string ssid)
        {
            this.connectionSsid = ssid;
        }

        public bool IsConnected()
        {
            return this.connected;
        }

        public void StartRecording()
        {
            if (connected == false || turnedOn == false)
            {
                Console.WriteLine("Nem tudsz felvételt indítani!");
            }
            else
            {
                this.Recording = true;
            }
        }

        public void StopRecording()
        {
            this.Recording = false;
        }
    }
}

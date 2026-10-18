using System;
using System.Collections.Generic;
using System.Text;

namespace OkosKamera
{
    internal interface IRecordable
    {
        public void StartRecording();
        public void StopRecording();
    }
}

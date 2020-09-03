using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public interface IDeviceController
    {
        void Update();
        DeviceControllerState GetInputState();
    }
}

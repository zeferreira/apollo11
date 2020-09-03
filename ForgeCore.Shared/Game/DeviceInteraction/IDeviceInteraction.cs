using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public interface IDeviceInteraction
    {
        void Update();
        DeviceInteracionEvent GetLastEvent();
    }
}

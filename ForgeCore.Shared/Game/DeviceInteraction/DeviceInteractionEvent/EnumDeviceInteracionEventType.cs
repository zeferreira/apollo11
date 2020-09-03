using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public enum EnumDeviceInteracionEventType
    {
        PressQuick, //event occurs when the user press and release the touch over the control
        Pressed, //event occurs when the user press the device over the control (and don't release)
        PressUp // event occurs when the user release the device over the control
    }
}

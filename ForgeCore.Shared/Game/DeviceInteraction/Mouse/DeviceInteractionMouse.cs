using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public class DeviceInteractionMouse : IDeviceInteraction
    {
        private DeviceInteracionEventMouse _lasEvent;

        public void Update()
        {
            DeviceInteracionEventMouse e = new DeviceInteracionEventMouse();

            MouseState state = Mouse.GetState();

            e.Position = state.Position.ToVector2();

            // Check if Right Mouse Button pressed, if so, exit
            if (state.RightButton == ButtonState.Pressed)
            {
                e.RightButtonPressed = true;
            }

            if (state.LeftButton == ButtonState.Pressed)
            {
                e.LeftButtonPressed = true;
            }
        }

        public DeviceInteracionEvent GetLastEvent()
        {
            return this._lasEvent;
        }
    }
}

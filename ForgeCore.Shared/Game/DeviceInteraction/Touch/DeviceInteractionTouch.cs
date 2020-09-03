using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;

namespace ForgeCore.Shared
{
    public class DeviceInteractionTouch : IDeviceInteraction
    {
        private DeviceInteracionEventTouch _lastEvent;

        public void Update()
        {
            DeviceInteracionEventTouch e = new DeviceInteracionEventTouch();

            TouchCollection touchCollection = TouchPanel.GetState();

            foreach (var item in touchCollection)
            {
                if (item.State == TouchLocationState.Pressed)
                {
                    //do what you want here when users tap the screen
                    e.Pressed = true;
                    e.Position = item.Position;
                }
            }

        }

        public DeviceInteracionEvent GetLastEvent()
        {
            return this._lastEvent;
        }
    }
}
